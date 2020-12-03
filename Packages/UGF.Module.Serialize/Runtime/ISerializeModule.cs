using UGF.Application.Runtime;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public interface ISerializeModule : IApplicationModule
    {
        new ISerializeModuleDescription Description { get; }
        ISerializerProvider Provider { get; }

        ISerializer<byte[]> GetDefaultBytesSerializer();
        ISerializer<string> GetDefaultTextSerializer();
        ISerializerBuilder GetSerializerBuilder(string id);
        bool TryGetSerializerBuilder(string id, out ISerializerBuilder builder);
    }
}
