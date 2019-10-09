using UGF.Description.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public interface ISerializeModuleDescription : IDescription
    {
        string DefaultBytesSerializerName { get; }
        string DefaultTextSerializerName { get; }
        string DefaultTextCompactSerializerName { get; }
        string DefaultTextReadableSerializerName { get; }
    }
}
