using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFront : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += transform.forward * -Time.deltaTime;
    }

}
