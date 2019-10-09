using System;
using UGF.Serialize.Runtime.Formatter;
using UGF.Serialize.Runtime.Unity;
using UnityEngine;

namespace UGF.Module.Serialize.Runtime
{
    [Serializable]
    public class SerializeModuleDescription : ISerializeModuleDescription
    {
        [SerializeField] private string m_defaultBytesSerializerName = SerializerFormatterUtility.SerializerBinaryName;
        [SerializeField] private string m_defaultTextSerializerName = SerializerUnityJsonUtility.SerializerTextCompactName;
        [SerializeField] private string m_defaultTextCompactSerializerName = SerializerUnityJsonUtility.SerializerTextCompactName;
        [SerializeField] private string m_defaultTextReadableSerializerName = SerializerUnityJsonUtility.SerializerTextReadableName;

        public string DefaultBytesSerializerName { get { return m_defaultBytesSerializerName; } set { m_defaultBytesSerializerName = value; } }
        public string DefaultTextSerializerName { get { return m_defaultTextSerializerName; } set { m_defaultTextSerializerName = value; } }
        public string DefaultTextCompactSerializerName { get { return m_defaultTextCompactSerializerName; } set { m_defaultTextCompactSerializerName = value; } }
        public string DefaultTextReadableSerializerName { get { return m_defaultTextReadableSerializerName; } set { m_defaultTextReadableSerializerName = value; } }
    }
}
