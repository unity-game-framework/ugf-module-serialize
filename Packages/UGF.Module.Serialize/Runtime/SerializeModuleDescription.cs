using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.EditorTools.Runtime.Ids;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModuleDescription : ApplicationModuleDescription, ISerializeModuleDescription
    {
        public GlobalId DefaultBytesSerializeId { get; }
        public GlobalId DefaultTextSerializerId { get; }
        public IReadOnlyDictionary<GlobalId, ISerializerBuilder> Serializers { get; }

        public SerializeModuleDescription(
            GlobalId defaultBytesSerializeId,
            GlobalId defaultTextSerializerId,
            IReadOnlyDictionary<GlobalId, ISerializerBuilder> serializers)
        {
            DefaultBytesSerializeId = defaultBytesSerializeId;
            DefaultTextSerializerId = defaultTextSerializerId;
            Serializers = serializers ?? throw new ArgumentNullException(nameof(serializers));
        }
    }
}
