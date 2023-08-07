using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private GameManager gameManager;
    private Pooling pooling;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        pooling = FindObjectOfType<Pooling>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.score += 1;
            gameObject.SetActive(false);
            pooling.NewPoolPosition();
            Debug.Log(gameObject.name + " se desactiva");
        }
    }
}
