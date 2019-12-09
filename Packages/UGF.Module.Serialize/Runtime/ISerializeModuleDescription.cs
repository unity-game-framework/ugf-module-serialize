namespace UGF.Module.Serialize.Runtime
{
    public interface ISerializeModuleDescription
    {
        string DefaultBytesSerializerName { get; }
        string DefaultTextSerializerName { get; }
        string DefaultTextCompactSerializerName { get; }
        string DefaultTextReadableSerializerName { get; }
    }
}
