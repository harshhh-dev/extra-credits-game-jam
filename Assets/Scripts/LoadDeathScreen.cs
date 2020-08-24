using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadDeathScreen : MonoBehaviour
{
    [SerializeField] Animator anim;

    public void playerLose()
    {
        StartCoroutine(Lose());
    }

    IEnumerator Lose()
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
