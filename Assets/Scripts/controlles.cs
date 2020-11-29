using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlles : MonoBehaviour
{
    private Rigidbody playerRib;
    public float jumpForce = 10;
    public float gravityModifer; // this will be modifed from the outside depending on the players mass 
    public bool isOnGround = true; 
    // Start is called before the first frame update
    void Start()
    {
        playerRib = GetComponent<Rigidbody>(); // we wanna get the rigidbody , because it deals with pyhsics and gravity better than transofrm
        //using get compent is like a reference , unlike transform

        // we wanna controll the gravity , so the jump can look real
        Physics.gravity *= gravityModifer;  // this will controll the gravity like we want to 
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isOnGround) 
        {
            playerRib.AddForce(Vector3.up * jumpForce,ForceMode.Impulse); // this will be * by  y which is equal to 1 automatically 
            //, 100 didnt work was to weak to notice the jump
            isOnGround = false; // so we set it to false , because once u hit the space bar , you are not on the ground anymore , which is flase 
            // so the whole statment is not True , therefore , the player cant jump agian 
        }
    }

    private void OnCollisionEnter(Collision collision) // when ever the player enters collison with the groun , becuas it has its own collider 
        // now we can set our isOnGround to True 
    {
        isOnGround = true;// if u go to the inspector for the player , u will see isonground box checked , thats beacuse its with collsion with
        // the ground that has a collider 
    }
}
