using UGF.Application.Runtime;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public interface ISerializeModule : IApplicationModule
    {
        ISerializeModuleDescription Description { get; }
        ISerializerProvider Provider { get; }

        ISerializer<byte[]> GetDefaultBytesSerializer();
        ISerializer<string> GetDefaultTextSerializer();
        ISerializerBuilder GetSerializerBuilder(string id);
        bool TryGetSerializerBuilder(string id, out ISerializerBuilder builder);
        string GetSerializerName(string id);
        bool TryGetSerializerName(string id, out string name);
    }
}
