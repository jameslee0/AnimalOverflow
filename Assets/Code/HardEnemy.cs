using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardEnemy : MonoBehaviour
{
    public GameObject enemy3;
    public Transform[] spawnerPos3;
    private float spawnTime;
    public float startTime3;

    void Update()
    {
        if (spawnTime <= 0)
        {
            int randPos = Random.Range(0, spawnerPos3.Length);
            Instantiate(enemy3, spawnerPos3[randPos].position, Quaternion.identity);
            spawnTime = startTime3;
            if(startTime3 > 1)
            {
                startTime3--;
            }
        }
        else
        {
            spawnTime -= Time.deltaTime;
        }
    }
}
