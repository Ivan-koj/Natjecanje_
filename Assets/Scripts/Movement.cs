using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;

    private Rigidbody2D theRB;
    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(left))
        {
            theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);
        } 
        else if(Input.GetKey(right))
        {
            theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
        }
        else
        {
            theRB.velocity = new Vector2(0, theRB.velocity.y);
        }

        if (Input.GetKey(up))
        {
            theRB.velocity = new Vector2(theRB.velocity.x, moveSpeed);
        }
        else if (Input.GetKey(down))
        {
            theRB.velocity = new Vector2(theRB.velocity.x, -moveSpeed);
        }
        else
        {
            theRB.velocity = new Vector2(theRB.velocity.x, 0);
        }
        
            
        
    }
}
