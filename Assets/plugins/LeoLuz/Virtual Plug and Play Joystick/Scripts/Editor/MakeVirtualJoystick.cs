using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
#endif
public class MakeVirtualJoystick : MonoBehaviour
{
    [MenuItem("GameObject/UI/Virtual Joystick")]
    public static void CreateMyAsset()
    {
        Object obj = Resources.Load("Joystick Canvas");
        GameObject _gameObject = (GameObject)Instantiate(obj, Vector3.zero, Quaternion.identity);
        _gameObject.name = "Joystick canvas";
        EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
    }

    [MenuItem("GameObject/UI/Virtual Joystick Digital")]
    public static void CreateVirtualJoyDigital()
    {
        Object obj = Resources.Load("Joystick Canvas Digital");
        GameObject _gameObject = (GameObject)Instantiate(obj, Vector3.zero, Quaternion.identity);
        _gameObject.name = "Joystick Canvas Digital";
        EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
    }
}
