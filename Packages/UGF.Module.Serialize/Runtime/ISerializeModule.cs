using UGF.Application.Runtime;
using UGF.RuntimeTools.Runtime.Providers;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public interface ISerializeModule : IApplicationModule
    {
        new ISerializeModuleDescription Description { get; }
        IProvider<string, ISerializer> Provider { get; }

        ISerializer<byte[]> GetDefaultBytesSerializer();
        ISerializer<string> GetDefaultTextSerializer();
    }
}
