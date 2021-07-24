using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObj : MonoBehaviour
{
    GameObject cam;
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }
    void Update()
    {
  
        if(cam.transform.position.z > transform.position.z)
        {
            Destroy(gameObject);
        }
    }

}
 