using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMovement : MonoBehaviour
{
    [SerializeField] private float min;
    [SerializeField] private float max;
    // [SerializeField] private float timeToWait = .2f;

    private Pooling pooling;

    private Vector3 offset;

    private void Start()
    {
        // StartCoroutine(HideObject());
        pooling = FindObjectOfType<Pooling>();
    }

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
        if (other.CompareTag("Kill"))
        {
            gameObject.SetActive(false);
            pooling.NewPoolPosition();
            Debug.Log(gameObject.name + " se ha desactivado");
        }

        if (other.CompareTag("Collectable"))
        {
            HideObject();
        }
    }

    private void HideObject()
    {
        gameObject.SetActive(false);
    }


    // IEnumerator HideObject()
    // {
    //     yield return new WaitForSeconds(timeToWait);
    //     gameObject.SetActive(false);
    //     Debug.Log(gameObject.name + " se desactiva");
    // }
}
