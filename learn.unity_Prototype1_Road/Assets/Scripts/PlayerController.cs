using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, 0, 0.05f);
        //transform.Translate(Vector3.forward * Time.deltaTime * 20); //It's more readable than 0,0,1.------ forward.Time.deltaTime * 20 is mean "MOVE FORWARD 20 METER PER SECOND !!!".
        transform.Translate(Vector3.forward * Time.deltaTime * speed);  //Now we can change the speed from the inspector.
    }
}
