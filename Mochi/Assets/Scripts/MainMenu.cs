using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string previousGameFile = "";

    public void StartNewGame()
    {
        string filePath = Application.dataPath + "/Resources/gameFiles";
        UnityEngine.Windows.File.Delete(filePath + "/0.txt");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Chapter0");
    }

    public void LoadGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Chapter0");
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
