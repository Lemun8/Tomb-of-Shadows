using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject pausemenu, settingsmenu, controlsmenu;
    public string sceneName;
    public bool toggle;
    public FPSController playerScript;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toggle = !toggle;
            if (toggle == false)
            {
                pausemenu.SetActive(false);
                settingsmenu.SetActive(false);
                AudioListener.pause = false;
                Time.timeScale = 1;
                playerScript.enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            if (toggle == true)
            {
                pausemenu.SetActive(true);
                AudioListener.pause = true;
                Time.timeScale = 0;
                playerScript.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
    public void toSettings()
    {
        pausemenu.SetActive(false);
        settingsmenu.SetActive(true);
    }
    public void controlsMenu()
    {
        pausemenu.SetActive(false);
        controlsmenu.SetActive(true);
    }
    public void backToPause()
    {
        settingsmenu.SetActive(false);
        pausemenu.SetActive(true);
        controlsmenu.SetActive(false);
    }
    public void resumeGame()
    {
        toggle = false;
        pausemenu.SetActive(false);
        AudioListener.pause = false;
        Time.timeScale = 1;
        playerScript.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void quitToMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene(sceneName);
    }
}