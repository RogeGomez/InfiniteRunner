using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingZone : MonoBehaviour
{
    public GameObject spawning;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle") || other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Collectable"))
        {
            other.transform.position = spawning.transform.position;
        }
    }
}
