using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{

    [SerializeField] Animator anim;

    public void RestartGame()
    {
        StartCoroutine(BackToGame());
    }

    IEnumerator BackToGame()
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
