using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour { 
    public Text scoreText;
    public Image backgroundImg;

    private bool isShowned = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (! isShowned)
            return;

    }
      public void ToggleEndMenu(float score)
       {
           gameObject.SetActive(true);
           scoreText.text = ((int)score).ToString();
           isShowned = true; 
       }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }


}
