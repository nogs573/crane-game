using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneMovement : MonoBehaviour
{    
    float motorShakeY = 0.002f; 
    float motorShakeInterval = 0.08f;  
    float nextMotorShake; //next time (in sec) motor should shake
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start of game");     
        nextMotorShake = motorShakeInterval;   
    }

    // Update is called once per frame
    void Update()
    {        
        int rotateY = 0; //degrees to rotate per frame around Y axis. 0 by default
        float moveZ = 0.0f;

        //MotorShake calculations. This can also be accomplished with InvokeRepeating(...)
        if (Time.time >= nextMotorShake)
        {
            //update next
            nextMotorShake = Time.time + motorShakeInterval;
            motorShakeY = motorShakeY*-1;
        }

        //get user input (wasd/arrow keys)
        float inputSide = Input.GetAxisRaw("Horizontal");
        float inputForward = Input.GetAxisRaw("Vertical");

        if (inputSide > 0)
            rotateY = 1;
        else if (inputSide < 0)
            rotateY = -1;

        if (inputForward > 0)
            moveZ = 0.01f;
        else if (inputForward < 0)
            moveZ = -0.01f;

        transform.Rotate(0,rotateY, 0);
        transform.Translate(0,motorShakeY,moveZ);  
    }
}
