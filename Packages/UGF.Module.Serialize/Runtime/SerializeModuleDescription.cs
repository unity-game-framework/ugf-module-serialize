using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.EditorTools.Runtime.Ids;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModuleDescription : ApplicationModuleDescription, ISerializeModuleDescription
    {
        public GlobalId DefaultBytesSerializeId { get; set; }
        public GlobalId DefaultTextSerializerId { get; set; }
        public Dictionary<GlobalId, ISerializerBuilder> Serializers { get; } = new Dictionary<GlobalId, ISerializerBuilder>();

        IReadOnlyDictionary<GlobalId, ISerializerBuilder> ISerializeModuleDescription.Serializers { get { return Serializers; } }
    }
}
