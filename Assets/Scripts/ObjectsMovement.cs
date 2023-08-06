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
        float rnd = Random.Range(min, max);
        transform.Translate(Vector3.left * rnd * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pool"))
        {
            this.gameObject.SetActive(false);
            Debug.Log(gameObject.name + " se regresa a la pool");
        }
    }
}
