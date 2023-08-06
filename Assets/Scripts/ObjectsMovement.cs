using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMovement : MonoBehaviour
{
    [SerializeField] private float min;
    [SerializeField] private float max;

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        // if (gameObject.CompareTag("Obstacle") || gameObject.CompareTag("Enemy") || gameObject.CompareTag("Collectable"))
        // {
        // }
        float rnd = Random.Range(min, max);
        transform.Translate(Vector3.left * rnd * Time.deltaTime);
    }
}
