using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public interface ISerializeModuleDescription : IApplicationModuleDescription
    {
        string DefaultBytesSerializeId { get; }
        string DefaultTextSerializerId { get; }
        IReadOnlyDictionary<string, ISerializerBuilder> Serializers { get; }
    }
}
