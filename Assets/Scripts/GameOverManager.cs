using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI ageText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nameText.text = PlayerPrefs.GetString("name");
        ageText.text = PlayerPrefs.GetString("age");
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

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }


    private void OnApplicationQuit()
    {
        if(PlayerPrefs.GetInt("remember") == 0)
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
