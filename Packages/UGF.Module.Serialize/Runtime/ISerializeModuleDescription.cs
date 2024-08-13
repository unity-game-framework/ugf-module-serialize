using System.Collections.Generic;
using UGF.Description.Runtime;
using UGF.EditorTools.Runtime.Ids;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public interface ISerializeModuleDescription : IDescription
    {
        GlobalId DefaultBytesSerializeId { get; }
        GlobalId DefaultTextSerializerId { get; }
        IReadOnlyDictionary<GlobalId, ISerializerBuilder> Serializers { get; }
    }
}
