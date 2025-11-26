using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using Newtonsoft.Json;
using System.IO;
using UnityEngine.WSA;

public class MainManager : MonoBehaviour
{


    public TMP_InputField name_InputField;
    public TMP_InputField age_InputField;

    public Toggle rememberToggle;


    private string path = "save/";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Data data = new Data();

        string json = File.ReadAllText(path+ $"data.json");
        Data data = JsonConvert.DeserializeObject<Data>(json);



        name_InputField.text = data.name;
        age_InputField.text = $"{data.age}";
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void Save()
    {
        // PlayerPrefs.SetString("name", name_InputField.text);
        // PlayerPrefs.SetString("age", age_InputField.text);
        Data data= new Data()
        {
            name = name_InputField.text,
            age = Int32.Parse(age_InputField.text),
            remember = rememberToggle.isOn
        };

        //data.name = name_InputField

        
        // if (rememberToggle.isOn)
        // {
        //     PlayerPrefs.SetInt("remember", 1);
        //     PlayerPrefs.Save();
        // }
        // else
        // {
        //     PlayerPrefs.SetInt("remember", 0);
        // }

        string json = JsonConvert.SerializeObject(data,Formatting.Indented);

        if (!File.Exists(path))
        {
            Directory.CreateDirectory("save/");
        }
        File.WriteAllText(path+ $"data.json", json);
        
        
    }

    public void Forget()
    {
        

        string json = File.ReadAllText(path+ $"data.json");
        Data data = JsonConvert.DeserializeObject<Data>(json);
        data.name = "";
        data.age = 0;
        json = JsonConvert.SerializeObject(data,Formatting.Indented);
        File.WriteAllText(path+ $"data.json", json);
        name_InputField.text = data.name;
        age_InputField.text = $"{data.age}";


        //JsonUtility.ToJson()

        


    }


    public void GoToLevel1()
    {
        SceneManager.LoadScene(1);
    }

}
