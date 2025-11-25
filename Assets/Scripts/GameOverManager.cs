using UnityEditor;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        //Application.Quit();
        #else
        
        Application.Quit();
        #endif
        
    }



    private void OnApplicationQuit()
    {
        if(PlayerPrefs.GetInt("remember") == 0)
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
