using UGF.Serialize.Runtime.Formatter;
using UGF.Serialize.Runtime.Unity;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModuleDescription : ISerializeModuleDescription
    {
        public string DefaultBytesSerializerName { get; set; } = SerializerFormatterUtility.SerializerBinaryName;
        public string DefaultTextSerializerName { get; set; } = SerializerUnityJsonUtility.SerializerTextCompactName;
        public string DefaultTextCompactSerializerName { get; set; } = SerializerUnityJsonUtility.SerializerTextCompactName;
        public string DefaultTextReadableSerializerName { get; set; } = SerializerUnityJsonUtility.SerializerTextReadableName;
    }
}
