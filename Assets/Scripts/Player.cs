using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private ScenesManager scenesManager;

    private Rigidbody2D rb;
    private Animator animator;

    [SerializeField] private float jumpForce;

    [SerializeField] private GameObject spawning;

    private bool isOnTheGround;

    public GameObject coinPrefab;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        scenesManager = FindObjectOfType<ScenesManager>();
        animator.SetBool("isRunning", true);
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
            animator.SetBool("isJumping", true);
            isOnTheGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Obstacle"))
        {
            animator.SetBool("isJumping", false);
            isOnTheGround = true;
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            scenesManager.GameOver();
            Debug.Log("Game Over");
        }
    }

    public void ReturnCoinToInitialPosition(GameObject coin)
    {
        coin.transform.position = spawning.transform.position;
    }
}
