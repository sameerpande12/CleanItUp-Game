using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onOffScript : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button nextLevelButton;
    [SerializeField] private GameObject pauseMenuUI;

    //private bool isPaused = false;
    
    // Start is called before the first frame update
    void Start()
    {
        pauseButton.onClick.AddListener(pauseGame);
        resumeButton.onClick.AddListener(resumeGame);
        nextLevelButton.onClick.AddListener(changeLevel);
        pauseMenuUI.SetActive(false);
    }

    void pauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
     //   isPaused = true;
    }

    void resumeGame()
    {
        Time.timeScale = 1f;
       // isPaused = false;
        pauseMenuUI.SetActive(false);

    }
    void changeLevel()
    {

    }
    
    
}
