using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0, 10, -18);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position; //Set the camera's position to the vehicle's position.
        //transform.position = player.transform.position + new Vector3(0, 10, -18); //Offset the camera behind the player by adding to the player's position BY usin' a "new" Vector3 that even doesn't exist yet.
        //transform.position = player.transform.position + offset; //It's better isn't it ;)

    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset; //To make camera's move much smooth.
    }

}
