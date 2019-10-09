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

            m_provider.Add(SerializerFormatterUtility.SerializerBinaryName, SerializerFormatterUtility.SerializerBinary);
            m_provider.Add(SerializerUnityJsonUtility.SerializerTextCompactName, SerializerUnityJsonUtility.SerializerTextCompact);
            m_provider.Add(SerializerUnityJsonUtility.SerializerTextReadableName, SerializerUnityJsonUtility.SerializerTextReadable);
            m_provider.Add(SerializerUnityJsonUtility.SerializerBytesName, SerializerUnityJsonUtility.SerializerBytes);
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
