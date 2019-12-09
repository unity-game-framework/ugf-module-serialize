using System;
using UGF.Application.Runtime;
using UGF.Serialize.Runtime;
using UGF.Serialize.Runtime.Formatter;
using UGF.Serialize.Runtime.Unity;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModule : ApplicationModuleBase, ISerializeModule
    {
        public ISerializeModuleDescription Description { get; }
        public ISerializerProvider Provider { get { return m_provider; } }

        private readonly SerializerProvider m_provider = new SerializerProvider();

        public SerializeModule(ISerializeModuleDescription description)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            m_provider.Add(SerializerFormatterUtility.SerializerBinaryName, SerializerFormatterUtility.SerializerBinary);
            m_provider.Add(SerializerUnityJsonUtility.SerializerTextCompactName, SerializerUnityJsonUtility.SerializerTextCompact);
            m_provider.Add(SerializerUnityJsonUtility.SerializerTextReadableName, SerializerUnityJsonUtility.SerializerTextReadable);
            m_provider.Add(SerializerUnityJsonUtility.SerializerBytesName, SerializerUnityJsonUtility.SerializerBytes);
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();

            m_provider.Remove<byte>(SerializerFormatterUtility.SerializerBinaryName);
            m_provider.Remove<string>(SerializerUnityJsonUtility.SerializerTextCompactName);
            m_provider.Remove<string>(SerializerUnityJsonUtility.SerializerTextReadableName);
            m_provider.Remove<byte>(SerializerUnityJsonUtility.SerializerBytesName);
        }

        public ISerializer<byte[]> GetDefaultBytesSerializer()
        {
            return m_provider.Get<byte[]>(Description.DefaultBytesSerializerName);
        }

        public ISerializer<string> GetDefaultTextSerializer()
        {
            return m_provider.Get<string>(Description.DefaultTextSerializerName);
        }
    }
}
