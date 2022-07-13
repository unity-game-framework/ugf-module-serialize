using UGF.Application.Runtime;
using UGF.EditorTools.Runtime.Ids;
using UGF.RuntimeTools.Runtime.Contexts;
using UGF.RuntimeTools.Runtime.Providers;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public interface ISerializeModule : IApplicationModule
    {
        new ISerializeModuleDescription Description { get; }
        IProvider<GlobalId, ISerializer> Provider { get; }
        IContext Context { get; }

        ISerializer<byte[]> GetDefaultBytesSerializer();
        ISerializer<string> GetDefaultTextSerializer();
    }
}
