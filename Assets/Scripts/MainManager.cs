using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{


    public TMP_InputField name_InputField;
    public TMP_InputField age_InputField;

    public Toggle rememberToggle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        name_InputField.text = PlayerPrefs.GetString("name");
        age_InputField.text = PlayerPrefs.GetString("age");
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void Save()
    {
        PlayerPrefs.SetString("name", name_InputField.text);
        PlayerPrefs.SetString("age", age_InputField.text);
        
        if (rememberToggle.isOn)
        {
            PlayerPrefs.SetInt("remember", 1);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetInt("remember", 0);
        }
        
    }

    public void Forget()
    {
        PlayerPrefs.DeleteAll();
        name_InputField.text = PlayerPrefs.GetString("name");
        age_InputField.text = PlayerPrefs.GetString("age");
    }


    public void GoToLevel1()
    {
        SceneManager.LoadScene(1);
    }

}
