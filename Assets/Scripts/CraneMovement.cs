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
        float moveX = 0.0f; //default is to not move
        float moveZ = 0.0f;

        //MotorShake calculations. This can also be accomplished with InvokeRepeating(...)
        if (Time.time >= nextMotorShake)
        {
            //update next
            nextMotorShake = Time.time + motorShakeInterval;
            motorShakeY = motorShakeY*-1;
        }

        //get user input (wasd/arrow keys)
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputZ = Input.GetAxisRaw("Vertical");

        if (inputX > 0)
            moveX = 0.01f;
        else if (inputX < 0)
            moveX = -0.01f;

        if (inputZ > 0)
            moveZ = 0.01f;
        else if (inputZ < 0)
            moveZ = -0.01f;

        transform.Translate(moveX,motorShakeY,moveZ);  
    }

}
