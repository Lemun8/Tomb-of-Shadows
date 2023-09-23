using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject menuObj, settingsObj, controlsObj;
    public string SceneName;
    public AudioSource onClick;
    public float waitTime;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void playGame()
    {
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.Save();
        StartCoroutine(loadToMenu());
    }
    public void SettingsMenu()
    {
        menuObj.SetActive(false);
        settingsObj.SetActive(true);
        onClick.Play();
    }
    public void controlsMenu()
    {
        menuObj.SetActive(false);
        controlsObj.SetActive(true);
        onClick.Play();
    }
    public void quitGame()
    {
        Debug.Log("This will quit the game, only works in actual build, not in Unity editor.");
        Application.Quit();
        onClick.Play();
    }
    public void backToMenu()
    {
        settingsObj.SetActive(false);
        menuObj.SetActive(true);
        controlsObj.SetActive(false);
        onClick.Play();
    }
    public void hopiumWebsite()
    {
        Application.OpenURL("https://hopium.itch.io/");
    }
    IEnumerator loadToMenu()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneName);
    }
}