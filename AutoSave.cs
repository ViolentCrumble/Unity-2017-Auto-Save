using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[InitializeOnLoad]
public class OnUnityLoad
{

    static OnUnityLoad()
    {
        EditorApplication.playmodeStateChanged = () =>
        {

            if (EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying)
            {

                Debug.Log("Auto-Saving scene before entering Play mode: ");

                EditorSceneManager.SaveOpenScenes();
                AssetDatabase.SaveAssets();
                
                
            }

        };

    }

}