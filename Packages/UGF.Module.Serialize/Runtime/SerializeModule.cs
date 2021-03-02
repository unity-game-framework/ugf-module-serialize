using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Logs.Runtime;
using UGF.RuntimeTools.Runtime.Providers;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModule : ApplicationModule<SerializeModuleDescription>, ISerializeModule
    {
        public IProvider<string, ISerializer> Provider { get; }

        ISerializeModuleDescription ISerializeModule.Description { get { return Description; } }

        public SerializeModule(SerializeModuleDescription description, IApplication application) : this(description, application, new Provider<string, ISerializer>())
        {
        }

        public SerializeModule(SerializeModuleDescription description, IApplication application, IProvider<string, ISerializer> provider) : base(description, application)
        {
            Provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            foreach (KeyValuePair<string, ISerializerBuilder> pair in Description.Serializers)
            {
                ISerializer serializer = pair.Value.Build();

                Provider.Add(pair.Key, serializer);
            }

            Log.Debug("Serialize Module initialized", new
            {
                serializers = Description.Serializers.Count,
                defaultBytes = Description.DefaultBytesSerializeId,
                defaultText = Description.DefaultTextSerializerId
            });
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();

            Provider.Clear();
        }

        public ISerializer<byte[]> GetDefaultBytesSerializer()
        {
            var serializer = Provider.Get<ISerializer<byte[]>>(Description.DefaultBytesSerializeId);

            return serializer;
        }

        public ISerializer<string> GetDefaultTextSerializer()
        {
            var serializer = Provider.Get<ISerializer<string>>(Description.DefaultTextSerializerId);

            return serializer;
        }
    }
}
