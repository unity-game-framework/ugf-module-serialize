using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.EditorTools.Runtime.Ids;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public interface ISerializeModuleDescription : IApplicationModuleDescription
    {
        GlobalId DefaultBytesSerializeId { get; }
        GlobalId DefaultTextSerializerId { get; }
        IReadOnlyDictionary<GlobalId, ISerializerBuilder> Serializers { get; }
    }
}
