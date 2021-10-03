using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float timeLeft = 5;
    public Text showHealth;
    public Text showTime;
    private Rigidbody2D body;
    private Vector2 moveSpeed;
    public float rotateSpeed;
    public int health = 20;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {

        faceMouse();
        Vector2 moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveSpeed = moveDir.normalized * speed;
        showHealth.text = "Band-Aids Left: " + health;
        timeLeft -= Time.deltaTime;
        showTime.text = "Time Left: " + Mathf.Round(timeLeft);

        if (timeLeft <= 0 || health <= 0)
        {
            SceneManager.LoadScene("TransitionScene");
        }
    }

    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = -direction;
    }
    private void FixedUpdate()
    {
        body.MovePosition(body.position + moveSpeed * Time.fixedDeltaTime);
    }
}
