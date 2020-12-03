using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.EditorTools.Runtime.IMGUI.AssetReferences;
using UGF.EditorTools.Runtime.IMGUI.Attributes;
using UGF.Serialize.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Runtime
{
    [CreateAssetMenu(menuName = "Unity Game Framework/Serialize/Serialize Module", order = 2000)]
    public class SerializeModuleAsset : ApplicationModuleAsset<ISerializeModule, SerializeModuleDescription>
    {
        [AssetGuid(typeof(SerializerAsset))]
        [SerializeField] private string m_defaultBytes;
        [AssetGuid(typeof(SerializerAsset))]
        [SerializeField] private string m_defaultText;
        [SerializeField] private List<AssetReference<SerializerAsset>> m_serializers = new List<AssetReference<SerializerAsset>>();

        public string DefaultBytes { get { return m_defaultBytes; } set { m_defaultBytes = value; } }
        public string DefaultText { get { return m_defaultText; } set { m_defaultText = value; } }
        public List<AssetReference<SerializerAsset>> Serializers { get { return m_serializers; } }

        protected override IApplicationModuleDescription OnBuildDescription()
        {
            var description = new SerializeModuleDescription(typeof(ISerializeModule))
            {
                DefaultBytesSerializeId = m_defaultBytes,
                DefaultTextSerializerId = m_defaultText
            };

            for (int i = 0; i < m_serializers.Count; i++)
            {
                AssetReference<SerializerAsset> reference = m_serializers[i];

                if (string.IsNullOrEmpty(reference.Guid)) throw new ArgumentException("Serializer asset id not specified.");
                if (reference.Asset == null) throw new ArgumentException($"Serializer asset not specified: '{reference.Guid}'.");

                description.Serializers.Add(reference.Guid, reference.Asset);
            }

            return description;
        }

        protected override ISerializeModule OnBuild(SerializeModuleDescription description, IApplication application)
        {
            return new SerializeModule(description, application);
        }
    }
}
