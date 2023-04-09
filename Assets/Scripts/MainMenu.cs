using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Text HighscoreText;
    // Start is called before the first frame update
    void Start()
    {
        HighscoreText.text = "Highscore :" + ((int)PlayerPrefs.GetFloat("Highscore")).ToString();


    }

    public void ToGame()
    {
        SceneManager.LoadScene("GAME");
    }
}
