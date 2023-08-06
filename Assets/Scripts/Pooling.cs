using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    [SerializeField] private GameObject spawningObjects;
    [SerializeField] private GameObject poolingZone;
    [SerializeField] private GameObject[] objectsPrefabs;

    private void Start()
    {
        StartCoroutine(Spawning());
    }

    IEnumerator Spawning()
    {
        while (true)
        {
            SpawningZone();
            float rnd = Random.Range(1, 3.5f);
            yield return new WaitForSeconds(rnd);
        }
    }

    private void SpawningZone()
    {
        int index = Random.Range(0, objectsPrefabs.Length);
        Instantiate(objectsPrefabs[index], spawningObjects.transform);
    }
}
