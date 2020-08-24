using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] Animator anim;

    private void Update()
    {
        if (Input.anyKey)
        {
            StartCoroutine(OntoGame());
        }
    }

    IEnumerator OntoGame()
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
