using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        Transform transform = this.transform;
        Vector3 pos =transform.position;

        if (Input.GetKeyDown(KeyCode.W))
        {
            pos.y +=1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            pos.y -=1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            pos.x += 1;
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            pos.x -= 1;
        }
    }
}
