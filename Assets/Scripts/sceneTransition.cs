using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour
{
    public string SceneName;
    public float waitTime;
    public AudioSource Flash;

    void OnMouseDown()
    {
        StartCoroutine(loadToMenu());
        Flash.Play();
    }

    IEnumerator loadToMenu()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneName);
    }
}
