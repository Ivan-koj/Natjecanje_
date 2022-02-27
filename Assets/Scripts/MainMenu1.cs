using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
        public static MainMenu1 instance;
        public string startScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
            SceneManager.LoadScene(startScene);
    }
    
    public void QuitGame() 
    {
            Application.Quit();
            Debug.Log(message:"Quitting game");
    }
    public void Credits()
    {
            SceneManager.LoadScene("Credits");
    }
    public void Back()
    {
            SceneManager.LoadScene("MainMenu");
    }
    public void Multiplayer()
    {
            SceneManager.LoadScene("Multiplayer");
    }

   
}
