using UGF.EditorTools.Editor.Assets;
using UGF.EditorTools.Editor.IMGUI;
using UGF.EditorTools.Editor.IMGUI.Scopes;
using UGF.Module.Serialize.Runtime;
using UnityEditor;

namespace UGF.Module.Serialize.Editor
{
    [CustomEditor(typeof(SerializeModuleAsset), true)]
    internal class SerializeModuleAssetEditor : UnityEditor.Editor
    {
        private SerializedProperty m_propertyDefaultBytes;
        private SerializedProperty m_propertyDefaultText;
        private AssetIdReferenceListDrawer m_listSerializers;
        private ReorderableListSelectionDrawerByPath m_listSerializersSelection;

        private void OnEnable()
        {
            m_propertyDefaultBytes = serializedObject.FindProperty("m_defaultBytes");
            m_propertyDefaultText = serializedObject.FindProperty("m_defaultText");

            m_listSerializers = new AssetIdReferenceListDrawer(serializedObject.FindProperty("m_serializers"));

            m_listSerializersSelection = new ReorderableListSelectionDrawerByPath(m_listSerializers, "m_asset")
            {
                Drawer = { DisplayTitlebar = true }
            };

            m_listSerializers.Enable();
            m_listSerializersSelection.Enable();
        }

        private void OnDisable()
        {
            m_listSerializers.Disable();
            m_listSerializersSelection.Disable();
        }

        public override void OnInspectorGUI()
        {
            using (new SerializedObjectUpdateScope(serializedObject))
            {
                EditorIMGUIUtility.DrawScriptProperty(serializedObject);

                EditorGUILayout.PropertyField(m_propertyDefaultBytes);
                EditorGUILayout.PropertyField(m_propertyDefaultText);

                m_listSerializers.DrawGUILayout();
                m_listSerializersSelection.DrawGUILayout();
            }
        }
    }
}
