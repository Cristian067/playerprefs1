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
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void Save()
    {
        PlayerPrefs.SetString("name", name_InputField.text);
        PlayerPrefs.SetInt("age", age_InputField.text.ConvertTo<int>());
        
        if (rememberToggle.isOn)
        {
            PlayerPrefs.Save();
        }
        
    }
    public void GoToLevel1()
    {
        SceneManager.LoadScene(1);
    }

}
