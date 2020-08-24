using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadWinScreen : MonoBehaviour
{

    [SerializeField] Animator anim;


    private void Update()
    {
        if (ScoreManager.score >= 120)
        {
            StartCoroutine(Win());
        }
    }
    IEnumerator Win ()
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
