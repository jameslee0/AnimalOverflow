using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject shot;
    private Transform player;

    void Start()
    {
        player = GetComponent<Transform>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(shot, player.position, Quaternion.identity);
        }
    }
}
