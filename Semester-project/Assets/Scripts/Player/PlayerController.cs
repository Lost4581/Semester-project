using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public int moveSpeed;
    [SerializeField] public int jumpForce;
    [SerializeField] private KeyCode jumpKey;
    private Rigidbody2D rb;
    private bool isGrounded = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(jumpKey) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("Enemy"))
        {
            isGrounded = true;
        }
    }
}