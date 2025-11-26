using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Newtonsoft.Json;
using System.IO;

public class GameOverManager : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI ageText;
    private string path = "save/";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string json = File.ReadAllText(path+ $"data.json");
        Data data = JsonConvert.DeserializeObject<Data>(json);



        nameText.text = data.name;
        ageText.text = $"{data.age}";
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
        string json = File.ReadAllText(path+ $"data.json");
        Data data = JsonConvert.DeserializeObject<Data>(json);
        if(!data.remember)
        {
            data.name = "";
            data.age = 0;
            json = JsonConvert.SerializeObject(data,Formatting.Indented);
            File.WriteAllText(path+ $"data.json", json);
        }
    }
}
