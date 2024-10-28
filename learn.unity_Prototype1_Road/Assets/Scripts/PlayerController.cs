using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 0;
    public float turnSpeed = 0; // for horizontal moving
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");

        //transform.Translate(0, 0, 0.05f); // 1
        //transform.Translate(Vector3.forward * Time.deltaTime * 20); // 2 It's more readable than 0,0,1.------ forward.Time.deltaTime * 20 is mean "MOVE FORWARD 20 METER PER SECOND !!!".
        transform.Translate(Vector3.forward * Time.deltaTime * speed);  // 3 Now we can change the speed from the inspector.


        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);// 1 for Horizontal move
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);// 2 controll player from keyboard
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput); // 3 Make vehicle rotate instead of slide

    }
}
