using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerNameManager : MonoBehaviour
{
    public InputField nameInputField;

    public void SavePlayerName()
    {
        string playerName = nameInputField.text; // Get text from input field
        if (!string.IsNullOrEmpty(playerName))
        { // Ensure name isn't empty
            PlayerPrefs.SetString("PlayerName", playerName); // Save name
            PlayerPrefs.Save(); // Ensure it's written to storage
            SceneManager.LoadScene("NextScene"); // Load the next scene
        }
        else
        {
            Debug.Log("Player name cannot be empty!"); // Show warning in console
        }
    }
}

