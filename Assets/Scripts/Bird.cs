using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("Settings")]
    Transform basket;
    [SerializeField] float speed;
    [Header("Polish")]
    [SerializeField] GameObject deathEffect;
    [SerializeField] GameObject[] deathSound;

    private void Start()
    {
        basket = GameObject.FindGameObjectWithTag("Basket").GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, basket.position, speed * Time.deltaTime);
    }

    void Dead()
    {
        ScoreManager.score += 1;
        Instantiate(deathEffect, transform.position, Quaternion.identity);

        int randSound = Random.Range(0, deathSound.Length);

        Instantiate(deathSound[randSound], transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Dead();
    }
}
