using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int rotateY = 0; //degrees to rotate per frame around Y axis. 0 by default
        float moveZ = 0.0f;

        //get user input (wasd/arrow keys)
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputZ = Input.GetAxisRaw("Vertical");

        if (inputX > 0)
            rotateY = 1;
        else if (inputX < 0)
            rotateY = -1;

        if (inputZ > 0)
            moveZ = 0.01f;
        else if (inputZ < 0)
            moveZ = -0.01f;

        transform.Rotate(0,rotateY, 0);
        transform.Translate(0,0,moveZ);        
    }
}
