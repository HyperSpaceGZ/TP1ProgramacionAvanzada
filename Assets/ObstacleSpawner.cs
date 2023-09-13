using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject spawner;
    public float spawnrate;

    void Start()
    {
        InvokeRepeating("SpawnCactus", 0, spawnrate);
    }

    public void SpawnCactus()
    {
        GameObject cactus = ObjectPool.SharedInstance.GetPooledObject();
        if (cactus != null)
        {
            cactus.transform.position = spawner.transform.position;
            cactus.transform.rotation = spawner.transform.rotation;
            cactus.SetActive(true);
        }
    }

}
