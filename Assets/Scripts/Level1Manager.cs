using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Manager : MonoBehaviour
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

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void GoToLevel2()
    {
        SceneManager.LoadScene(2);
    }
}
