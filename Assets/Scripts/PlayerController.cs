using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
      myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetAxisRaw("Horizontal") > 0f) {
        myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);
      } else if (Input.GetAxisRaw("Horizontal") < 0f) {
        myRigidBody.velocity = new Vector2(-moveSpeed, myRigidBody.velocity.y);
      } else {
        myRigidBody.velocity = new Vector2(0, myRigidBody.velocity.y);
      }
        
    }
}
