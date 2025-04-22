using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{


    public GameObject pauseMenu;

   // public GameObject quit;

    //public GameObject pauseMenuFirst;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            
            PauseUnpause();
            
        }
    }

    public void PauseUnpause()
    {
        if (!pauseMenu.activeSelf)
        {
            //EventSystem.current.SetSelectedGameObject(null);
            //EventSystem.current.SetSelectedGameObject(pauseMenuFirst);
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
           Cursor.visible = true;
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
           Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }


  
}