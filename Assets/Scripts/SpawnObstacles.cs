using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstaclesPrefab; // were we can insert the obstacle prefab 
    private Vector3 spawnPos = new Vector3(20, 0, 0); // obstacel postion 20 left of the x-axis 
    private float starDelay = 1.0f;
    private float timeRepate = 2;
    private controlles controllescript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spwanObstacles", starDelay,timeRepate); // will spawn objects on a timer  

        controllescript = GameObject.Find("Player").GetComponent<controlles>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spwanObstacles()
    {
        if(controllescript.gameOver == false)
        {
            Instantiate(obstaclesPrefab, spawnPos, obstaclesPrefab.transform.rotation); // will create clones of the object prefab obnstacles prefab
        }
    }
        
}
