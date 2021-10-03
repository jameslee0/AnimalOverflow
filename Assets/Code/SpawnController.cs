using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnerPos;
    private float spawnTime;
    public float startTime;

    void Update()
    {
        if(spawnTime <= 0)
        {
            int randPos = Random.Range(0, spawnerPos.Length);
            Instantiate(enemy, spawnerPos[randPos].position, Quaternion.identity);
            spawnTime = startTime;
        }
        else
        {
            spawnTime -= Time.deltaTime;
        }
    }
}
