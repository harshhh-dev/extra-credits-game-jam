using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] float moveSpeed;

    public Rigidbody2D rb;
    Vector2 moveVelocity;

    private void Update()
    {
        Vector2 movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = movementInput.normalized * moveSpeed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
