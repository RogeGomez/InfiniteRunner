using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    [SerializeField] private GameObject spawningObjects;
    [SerializeField] private GameObject poolingZone;
    [SerializeField] private GameObject[] objectsPrefabs;

    [SerializeField] private List<GameObject> objectsList;
    [SerializeField] private int objectsSize = 10;

    [SerializeField] private GameObject player;

    private void Start()
    {
        objectsList = new List<GameObject>();
        AddObjectsToPool(objectsSize);
        StartCoroutine(Spawning());
    }

    private void AddObjectsToPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int index = Random.Range(0, objectsPrefabs.Length);
            GameObject obj = Instantiate(objectsPrefabs[index], spawningObjects.transform);
            obj.SetActive(false);
            objectsList.Add(obj);
        }
    }

    private GameObject RequestObjects()
    {
        for (int i = 0; i < objectsSize; i++)
        {
            if (!objectsList[i].activeInHierarchy)
            {
                objectsList[i].SetActive(true);
                return objectsList[i];
            }
        }
        return null;
    }

    IEnumerator Spawning()
    {
        while (true)
        {
            RequestObjects();
            float rnd = Random.Range(1, 3.5f);
            yield return new WaitForSeconds(rnd);
        }
    }

    public void NewPoolPosition()
    {
        Vector3 offset = new Vector3(17.15f, -0.8f, 0);
        transform.position = player.transform.position + offset;
    }

}
