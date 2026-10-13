using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour

{ 
public float moveSpeed;
public float jumpHeight;
public KeyCode SpaceBar;
public KeyCode L;
public KeyCode R;
private Animator anim;
public Transform groundcheck;
public float groundcheckRadius;
public LayerMask whatIsGround;
private bool grounded;

    
    void Start()
    {
         anim = GetComponent<Animator>();
    }

   
void Update (){ 
    if (Input.GetKeyDown(SpaceBar) && grounded)
{
    Jump();
}


 

if(Input.GetKeyDown(SpaceBar) && grounded) 
{
Jump(); 
}

if (Input.GetKey(L)) 
{
GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y); 

if (GetComponent<SpriteRenderer>()!=null)
{
    GetComponent<SpriteRenderer>().flipX = true;
}
anim.SetFloat("Speed",Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
}

if (Input.GetKey(R)) 
{
GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>() . velocity.y); 

if (GetComponent<SpriteRenderer>() !=null)
{
    GetComponent<SpriteRenderer>().flipX = false;
}

anim.SetFloat("Speed",Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
anim.SetFloat("Height", GetComponent<Rigidbody2D>().velocity.y);
anim.SetBool("Ground", grounded);
}
}
void Jump()
{ 
GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);  

    }
   

 void FixedUpdate()

   {
    grounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckRadius,whatIsGround);
}



}

