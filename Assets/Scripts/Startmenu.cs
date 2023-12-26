using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenuManager : MonoBehaviour
{
    public TMP_InputField playerNameInputField;

    public void StartGame()
    {
        string playerName = playerNameInputField.text;
        PlayerPrefs.SetString("CurrentPlayer", playerName);
        SceneManager.LoadScene("main"); // Replace with your main game scene name
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
