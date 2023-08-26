using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private Player player;

    private GameManager gameManager;


    private void Start()
    {
        player = FindObjectOfType<Player>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.score += 1;
            player.ReturnCoinToInitialPosition(gameObject);
            gameObject.SetActive(false);
            // Debug.Log(gameObject.name + " se regresa a su posición original");
        }
    }
}
