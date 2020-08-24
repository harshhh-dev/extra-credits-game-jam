using UnityEngine;

public class Cloud : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        transform.Translate(speed, 0f, 0f * Time.deltaTime);
    }
}
