using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumEnemy : MonoBehaviour
{
    public GameObject enemy2;
    public Transform[] spawnerPos2;
    private float spawnTime;
    public float startTime2;

    void Update()
    {
        if (spawnTime <= 0)
        {
            int randPos = Random.Range(0, spawnerPos2.Length);
            Instantiate(enemy2, spawnerPos2[randPos].position, Quaternion.identity);
            spawnTime = startTime2;
            if (startTime2 > 1)
            {
                startTime2--;
            }
        }
        else
        {
            spawnTime -= Time.deltaTime;
        }
    }
}
