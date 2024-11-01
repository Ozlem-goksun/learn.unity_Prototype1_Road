# [Unity Learn](https://learn.unity.com)/[Junior Programming Pathway](https://learn.unity.com/pathway/junior-programmer) UNIT 1 </br>

## Prototype 1
### To try out this small, tiny, 🤏 and even microscopic game, click on the GIF below.
[<img src="https://github.com/Ozlem-goksun/learn.unity_Prototype1_Road/blob/main/WebGl%20Buildings/Prototype1/prototype1.gif" alt="prototype1" style="max-width: 100%; height: auto;">](https://play.unity.com/en/games/1e548ec8-1ac3-4203-a646-858d8362803d/junior-programmer-prototype1)
In this miniature game lookalike "thing", you can move left and right by clicking the "A" and "D" keys, and nothing else for now.

## Challenge 1
As the first task of this training, I corrected errors in the code of an airplane that was moving backwards and circling very fast, and also made its propeller rotate via the code.

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject propeller;

    public float speed = 0;
    public float rotationSpeed = 0;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(0, 0, 2);
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed * verticalInput);
    }
}
```



[<img src="https://github.com/Ozlem-goksun/learn.unity_Prototype1_Road/blob/main/WebGl%20Buildings/Challenge1/challenge1.gif" alt="challenge1" style="max-width: 100%; height: auto;">](https://play.unity.com/en/games/e99926ee-4a25-44ef-b40e-2b3b3fac7898/junior-programmer-challenge1)


