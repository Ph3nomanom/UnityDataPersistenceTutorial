using System.Collections;
using System.Collections.Generic;
using TMPro; // Add this at the top
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuManager : MonoBehaviour
{
    public TMP_InputField playerNameInputField;
    public static string PlayerName;

    public void StartGame()
    {
        PlayerName = playerNameInputField.text;
        SceneManager.LoadScene("main"); // Replace with your main game scene name
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}

