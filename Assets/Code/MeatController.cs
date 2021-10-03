using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatController : MonoBehaviour
{
    private Vector2 cursor;
    public float speed;


    void Start()
    {
        cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, cursor, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, cursor) < 0.2f)
        {
            Destroy(gameObject);
        }
    }
}
