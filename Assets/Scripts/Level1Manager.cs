using System.IO;
using Newtonsoft.Json;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Manager : MonoBehaviour
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

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void GoToLevel2()
    {
        SceneManager.LoadScene(2);
    }
}
