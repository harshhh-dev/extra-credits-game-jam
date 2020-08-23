using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] float timeB4Death;

    private void Start()
    {
        Destroy(gameObject, timeB4Death);
    }
}
