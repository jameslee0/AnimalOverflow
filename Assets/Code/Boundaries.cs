using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objWidth;
    private float objHeight;

    /* Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }
    Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x + objWidth, screenBounds.x * -1 - objWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objHeight, screenBounds.y * -1 - objHeight);
        transform.position = viewPos;
    */

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9f, 9f),
            Mathf.Clamp(transform.position.y, -5f, 5f), transform.position.z);
    }
}
