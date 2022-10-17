using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{    public Rigidbody2D rb;
     private float dirX;
     public float speed;
     private BoxCollider2D col;
     public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        col=GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")& IsGrounded())
            {
                rb.velocity=new Vector2(0,10);
            }
            dirX=Input.GetAxisRaw("Horizontal");
            rb.velocity=new Vector2(dirX*speed,rb.velocity.y);
    }
    private bool IsGrounded(){
        return Physics2D.BoxCast(col.bounds.center,col.bounds.size,0,Vector2.down,0.2f,groundLayer);
    }
}
