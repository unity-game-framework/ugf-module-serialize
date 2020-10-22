using System.Collections.Generic;
using UGF.EditorTools.Runtime.IMGUI.AssetReferences;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public interface ISerializeModuleDescription
    {
        string DefaultBytesSerializeId { get; }
        string DefaultTextSerializerId { get; }
        IReadOnlyList<AssetReference<SerializerAsset>> Serializers { get; }
    }
}
