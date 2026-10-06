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

public Transform GroundCheck;




    
    void Start()
    {
        
    }

   
void Update (){ 
 

if(Input.GetKeyDown(SpaceBar)) 
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

}

if (Input.GetKey(R)) 
{
GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>() . velocity.y); 

if (GetComponent<SpriteRenderer>() !=null)
{
    GetComponent<SpriteRenderer>().flipX = false;
}

}
}

void Jump()
{ 
GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);  

    }
 




}

