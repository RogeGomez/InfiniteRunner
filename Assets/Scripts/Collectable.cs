using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.score += 1;
            gameObject.SetActive(false);
            Debug.Log(gameObject.name + " se regresa a la pool");
        }
        // TODO HACER QUE SE REGRESE A LA POOL DESPUÉS DE 10 SEGUNDOS
    }
}
