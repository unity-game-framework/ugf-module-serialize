using System;
using UGF.Application.Runtime;
using UGF.EditorTools.Runtime.Ids;
using UGF.Logs.Runtime;
using UGF.RuntimeTools.Runtime.Contexts;
using UGF.RuntimeTools.Runtime.Providers;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModule : ApplicationModule<SerializeModuleDescription>, ISerializeModule
    {
        public IProvider<GlobalId, ISerializer> Provider { get; }
        public IContext Context { get; }

        ISerializeModuleDescription ISerializeModule.Description { get { return Description; } }

        private readonly ILog m_logger;

        public SerializeModule(SerializeModuleDescription description, IApplication application) : this(description, application, new Provider<GlobalId, ISerializer>(), new Context { application })
        {
        }

        public SerializeModule(SerializeModuleDescription description, IApplication application, IProvider<GlobalId, ISerializer> provider, IContext context) : base(description, application)
        {
            Provider = provider ?? throw new ArgumentNullException(nameof(provider));
            Context = context ?? throw new ArgumentNullException(nameof(context));

            m_logger = Log.CreateWithLabel<SerializeModule>();
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            foreach ((GlobalId key, ISerializerBuilder value) in Description.Serializers)
            {
                ISerializer serializer = value.Build();

                Provider.Add(key, serializer);
            }

            m_logger.Debug("Serialize Module initialized", new
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
