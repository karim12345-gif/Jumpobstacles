using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private controlles controllescript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
       controllescript = GameObject.Find("Player").GetComponent<controlles>();// getting the player and the controlles component 
    }

    // Update is called once per frame
    void Update()
    {
        if(controllescript.gameOver == false) // game is not over yet 
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed); // this will make the obstacle move left using the speed and the vector 3.left where x= -1
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacels"))
        {
            Destroy(gameObject);

        }
        
        
    }
}
