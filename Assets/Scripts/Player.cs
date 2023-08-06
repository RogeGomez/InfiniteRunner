using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private ScenesManager scenesManager;

    private Rigidbody2D rb;

    [SerializeField] private float jumpForce;

    private bool isOnTheGround;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scenesManager = FindObjectOfType<ScenesManager>();
    }

    private void Update()
    {
        Jumping();
    }

    private void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnTheGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Obstacle"))
        {
            isOnTheGround = true;
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            scenesManager.GameOver();
            Debug.Log("Game Over");
        }
    }
}
