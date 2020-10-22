using System;
using UGF.Application.Runtime;
using UGF.EditorTools.Runtime.IMGUI.AssetReferences;
using UGF.Serialize.Runtime;

namespace UGF.Module.Serialize.Runtime
{
    public class SerializeModule : ApplicationModuleBase, ISerializeModule
    {
        public ISerializeModuleDescription Description { get; }
        public ISerializerProvider Provider { get; }

        public SerializeModule(ISerializeModuleDescription description, ISerializerProvider provider = null)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Provider = provider ?? new SerializerProvider();
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();
        }

        public ISerializer<byte[]> GetDefaultBytesSerializer()
        {
        }

        public ISerializer<string> GetDefaultTextSerializer()
        {
        }

        public ISerializerBuilder GetSerializerBuilder(string id)
        {
            return TryGetSerializerBuilder(id, out ISerializerBuilder builder) ? builder : throw new ArgumentException($"Serializer builder not found by the specified id: '{id}'.");
        }

        public bool TryGetSerializerBuilder(string id, out ISerializerBuilder builder)
        {
        }

        public string GetSerializerName(string id)
        {
            return TryGetSerializerName(id, out string name) ? name : throw new ArgumentException($"Serializer name not found by the specified id: '{id}'.");
        }

        public bool TryGetSerializerName(string id, out string name)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentException("Value cannot be null or empty.", nameof(id));

            for (int i = 0; i < Description.Serializers.Count; i++)
            {
                AssetReference<SerializerAsset> reference = Description.Serializers[i];

                if (reference.Guid == id)
                {
                    name = reference.Asset.Name;

                    return true;
                }
            }

            name = default;
            return false;
        }
    }
}
