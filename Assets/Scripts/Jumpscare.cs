using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumpscare : MonoBehaviour
{
    public Animator jumpscareAnim;
    public GameObject player;
    public float jumpscareTime;
    public string sceneName;
    public EnemyMonsterAI monsterscript;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            monsterscript.enabled = false;
            jumpscareAnim.ResetTrigger("idle");
            jumpscareAnim.ResetTrigger("walk");
            jumpscareAnim.ResetTrigger("run");
            jumpscareAnim.SetTrigger("jumpscare");
            StartCoroutine(jumpscare());
        }
    }
    IEnumerator jumpscare()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
    }
}
