using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public bool isScene2Active = false;
    public bool isScene3Active = false;
    public static Menu Instance;
    
   



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.Log("hello");
            
        }
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void Quit()
    {
        Application.Quit();
    }


    public void LoadScene1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void LoadScene2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }

    public void LoadScene3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }





}
