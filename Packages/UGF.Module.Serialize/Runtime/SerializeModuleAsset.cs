using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.EditorTools.Runtime.IMGUI.AssetReferences;
using UGF.EditorTools.Runtime.IMGUI.Attributes;
using UGF.Serialize.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModuleAsset : ApplicationModuleAsset<ISerializeModule>, ISerializeModuleDescription
    {
        [AssetGuid(typeof(SerializerAsset))]
        [SerializeField] private string m_defaultBytes;
        [AssetGuid(typeof(SerializerAsset))]
        [SerializeField] private string m_defaultText;
        [SerializeField] private List<AssetReference<SerializerAsset>> m_serializers = new List<AssetReference<SerializerAsset>>();

        public string DefaultBytes { get { return m_defaultBytes; } set { m_defaultBytes = value; } }
        public string DefaultText { get { return m_defaultText; } set { m_defaultText = value; } }
        public List<AssetReference<SerializerAsset>> Serializers { get { return m_serializers; } }

        string ISerializeModuleDescription.DefaultBytesSerializeId { get { return m_defaultBytes; } }
        string ISerializeModuleDescription.DefaultTextSerializerId { get { return m_defaultText; } }
        IReadOnlyList<AssetReference<SerializerAsset>> ISerializeModuleDescription.Serializers { get { return Serializers; } }

        protected override ISerializeModule OnBuildTyped(IApplication application)
        {
            return new SerializeModule(this);
        }
    }
}
