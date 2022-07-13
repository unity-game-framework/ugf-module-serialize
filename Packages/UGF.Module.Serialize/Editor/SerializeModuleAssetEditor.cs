using UGF.EditorTools.Editor.IMGUI;
using UGF.EditorTools.Editor.IMGUI.Scopes;
using UGF.Module.Serialize.Runtime;
using UnityEditor;

namespace UGF.Module.Serialize.Editor
{
    [CustomEditor(typeof(SerializeModuleAsset), true)]
    internal class SerializeModuleAssetEditor : UnityEditor.Editor
    {
        private SerializedProperty m_propertyScript;
        private SerializedProperty m_propertyDefaultBytes;
        private SerializedProperty m_propertyDefaultText;
        private ReorderableListDrawer m_list;

        private void OnEnable()
        {
            m_propertyScript = serializedObject.FindProperty("m_Script");
            m_propertyDefaultBytes = serializedObject.FindProperty("m_defaultBytes");
            m_propertyDefaultText = serializedObject.FindProperty("m_defaultText");

            m_list = new ReorderableListDrawer(serializedObject.FindProperty("m_serializers"))
            {
                DisplayAsSingleLine = true
            };

            m_list.Enable();
        }

        private void OnDisable()
        {
            m_list.Disable();
        }

        public override void OnInspectorGUI()
        {
            using (new SerializedObjectUpdateScope(serializedObject))
            {
                using (new EditorGUI.DisabledScope(true))
                {
                    EditorGUILayout.PropertyField(m_propertyScript);
                }

                EditorGUILayout.PropertyField(m_propertyDefaultBytes);
                EditorGUILayout.PropertyField(m_propertyDefaultText);

                m_list.DrawGUILayout();
            }
        }
    }
}
