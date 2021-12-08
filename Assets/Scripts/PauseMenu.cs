using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public string levelSelect, mainMenu;
    public GameObject pauseScreen;
    public bool IsPause=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUnpause();
        }
    }

    public void PauseUnpause()
    {
        if (IsPause)
        {
            Time.timeScale = 1f;
            IsPause = false;
            pauseScreen.SetActive(false);
        }
        else
        {
            Time.timeScale = 0f;
            IsPause = true;
            pauseScreen.SetActive(true);
        }
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }
   

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log(message:"Quitting game");
    }
}
