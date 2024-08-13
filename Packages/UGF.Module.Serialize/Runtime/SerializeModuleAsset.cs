using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.EditorTools.Runtime.Assets;
using UGF.EditorTools.Runtime.Ids;
using UGF.Serialize.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Runtime
{
    [CreateAssetMenu(menuName = "Unity Game Framework/Serialize/Serialize Module", order = 2000)]
    public class SerializeModuleAsset : ApplicationModuleAsset<ISerializeModule, SerializeModuleDescription>
    {
        [AssetId(typeof(SerializerAsset))]
        [SerializeField] private Hash128 m_defaultBytes;
        [AssetId(typeof(SerializerAsset))]
        [SerializeField] private Hash128 m_defaultText;
        [SerializeField] private List<AssetIdReference<SerializerAsset>> m_serializers = new List<AssetIdReference<SerializerAsset>>();

        public GlobalId DefaultBytes { get { return m_defaultBytes; } set { m_defaultBytes = value; } }
        public GlobalId DefaultText { get { return m_defaultText; } set { m_defaultText = value; } }
        public List<AssetIdReference<SerializerAsset>> Serializers { get { return m_serializers; } }

        protected override SerializeModuleDescription OnBuildDescription()
        {
            var serializers = new Dictionary<GlobalId, ISerializerBuilder>();

            for (int i = 0; i < m_serializers.Count; i++)
            {
                AssetIdReference<SerializerAsset> reference = m_serializers[i];

                serializers.Add(reference.Guid, reference.Asset);
            }

            return new SerializeModuleDescription(m_defaultBytes, m_defaultText, serializers);
        }

        protected override ISerializeModule OnBuild(SerializeModuleDescription description, IApplication application)
        {
            return new SerializeModule(description, application);
        }
    }
}
