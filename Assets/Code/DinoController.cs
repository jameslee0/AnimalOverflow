using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour
{
    private Rigidbody2D charRigid;
    private bool FacingRight = true;
    private Vector3 CharVelocity = Vector3.zero;

    // Start is called before the first frame update
    void awake()
    {
        charRigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(float move)
    {
        Vector3 targetVelocity = new Vector2(move * 10f, charRigid.velocity.y);
        if(move > 0 && !FacingRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        FacingRight = !FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
