using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCollider : MonoBehaviour
{
    public static RedCollider _instance;
    public int hittingObjectCount=1;

    private void Awake()
    {
        _instance = this;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RedCaseCollected")
        {
            Destroy(collision.gameObject);
            Finish._instance.MakeColored(((hittingObjectCount) * 4)+1,Finish._instance.redCaseColor);

            hittingObjectCount++;

            
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
