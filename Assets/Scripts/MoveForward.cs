using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start of game");        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f,0.0f,0.01f);  
    }
}
