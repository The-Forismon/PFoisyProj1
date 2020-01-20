using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureSpawn : MonoBehaviour
{
    
    public GameObject treasure;
    public Vector3 SpawnValues;
    // Start is called before the first frame update
    void Start()
    {
    
        SpawnStuff();
    }

    void SpawnStuff()
    {
        float randX = Random.Range(-SpawnValues.x, SpawnValues.x); //these two variables find the range in which the object can appear
        float randY = Random.Range(-SpawnValues.y, SpawnValues.y);

        Vector3 spawnPosition = new Vector3(randX, randY, 0); //this turns the variables into an actual position
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(original: treasure, position: spawnPosition, rotation: spawnRotation);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

}
