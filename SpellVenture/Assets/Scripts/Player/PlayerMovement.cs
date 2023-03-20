using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(0,2500)] float speed, minSpeed, maxSpeed;

    Rigidbody2D rb2d;
    Animator anim;
    SpriteRenderer sprite;
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {
        float moveX = /*Input.GetAxisRaw("Horizontal")*/ 0;
       
        if (moveX>0)
		{
            sprite.flipX = false;
            speed = maxSpeed;
		}
        else if(moveX<0)
		{
            sprite.flipX = true;
            speed = minSpeed;
		}
    }
	

    public void Move()
	{
        rb2d.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.fixedDeltaTime, rb2d.velocity.y, this.transform.position.z);
    }
    public void MoveLeft()
	{
        rb2d.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.fixedDeltaTime, rb2d.velocity.y, this.transform.position.z);
    }
  
}
