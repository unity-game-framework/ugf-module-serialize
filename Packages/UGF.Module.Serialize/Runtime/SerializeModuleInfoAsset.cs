using UGF.Application.Runtime;
using UGF.Serialize.Runtime.Formatter;
using UGF.Serialize.Runtime.Unity;
using UnityEngine;

namespace UGF.Module.Serialize.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Serialize/SerializeModuleInfo", order = 2000)]
    public class SerializeModuleInfoAsset : ApplicationModuleInfoAsset<ISerializeModule>
    {
        [SerializeField] private string m_defaultBytesSerializerName = SerializerFormatterUtility.SerializerBinaryName;
        [SerializeField] private string m_defaultTextSerializerName = SerializerUnityJsonUtility.SerializerTextCompactName;
        [SerializeField] private string m_defaultTextCompactSerializerName = SerializerUnityJsonUtility.SerializerTextCompactName;
        [SerializeField] private string m_defaultTextReadableSerializerName = SerializerUnityJsonUtility.SerializerTextReadableName;

        public string DefaultBytesSerializerName { get { return m_defaultBytesSerializerName; } set { m_defaultBytesSerializerName = value; } }
        public string DefaultTextSerializerName { get { return m_defaultTextSerializerName; } set { m_defaultTextSerializerName = value; } }
        public string DefaultTextCompactSerializerName { get { return m_defaultTextCompactSerializerName; } set { m_defaultTextCompactSerializerName = value; } }
        public string DefaultTextReadableSerializerName { get { return m_defaultTextReadableSerializerName; } set { m_defaultTextReadableSerializerName = value; } }

        public ISerializeModuleDescription GetDescription()
        {
            return new SerializeModuleDescription
            {
                DefaultBytesSerializerName = m_defaultBytesSerializerName,
                DefaultTextSerializerName = m_defaultTextSerializerName,
                DefaultTextCompactSerializerName = m_defaultTextCompactSerializerName,
                DefaultTextReadableSerializerName = m_defaultTextReadableSerializerName
            };
        }

        protected override IApplicationModule OnBuild(IApplication application)
        {
            ISerializeModuleDescription description = GetDescription();

            return new SerializeModule(description);
        }
    }
}
