using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Logs.Runtime;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModule : ApplicationModule<SerializeModuleDescription>, ISerializeModule
    {
        public ISerializerProvider Provider { get; }

        ISerializeModuleDescription ISerializeModule.Description { get { return Description; } }

        public SerializeModule(SerializeModuleDescription description, IApplication application) : this(description, application, new SerializerProvider())
        {
        }

        public SerializeModule(SerializeModuleDescription description, IApplication application, ISerializerProvider provider) : base(description, application)
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
                types = Provider.DataTypesCount,
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
            ISerializer<byte[]> serializer = Provider.Get<byte[]>(Description.DefaultBytesSerializeId);

            return serializer;
        }

        public ISerializer<string> GetDefaultTextSerializer()
        {
            ISerializer<string> serializer = Provider.Get<string>(Description.DefaultTextSerializerId);

            return serializer;
        }

        public ISerializerBuilder GetSerializerBuilder(string id)
        {
            return TryGetSerializerBuilder(id, out ISerializerBuilder builder) ? builder : throw new ArgumentException($"Serializer builder not found by the specified id: '{id}'.");
        }

        public bool TryGetSerializerBuilder(string id, out ISerializerBuilder builder)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentException("Value cannot be null or empty.", nameof(id));

            return Description.Serializers.TryGetValue(id, out builder);
        }
    }
}
