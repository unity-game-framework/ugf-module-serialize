﻿using System;
using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.EditorTools.Runtime.IMGUI.AssetReferences;
using UGF.EditorTools.Runtime.IMGUI.Attributes;
using UGF.Serialize.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Serialize/Serialize Module", order = 2000)]
    public class SerializeModuleAsset : ApplicationModuleDescribedAsset<ISerializeModule, SerializeModuleDescription>
    {
        [AssetGuid(typeof(SerializerAsset))]
        [SerializeField] private string m_defaultBytes;
        [AssetGuid(typeof(SerializerAsset))]
        [SerializeField] private string m_defaultText;
        [SerializeField] private List<AssetReference<SerializerAsset>> m_serializers = new List<AssetReference<SerializerAsset>>();

        public string DefaultBytes { get { return m_defaultBytes; } set { m_defaultBytes = value; } }
        public string DefaultText { get { return m_defaultText; } set { m_defaultText = value; } }
        public List<AssetReference<SerializerAsset>> Serializers { get { return m_serializers; } }

        protected override SerializeModuleDescription OnGetDescription(IApplication application)
        {
            var description = new SerializeModuleDescription
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

        protected override ISerializeModule OnBuild(IApplication application, SerializeModuleDescription description)
        {
            return new SerializeModule(application, description);
        }
    }
}