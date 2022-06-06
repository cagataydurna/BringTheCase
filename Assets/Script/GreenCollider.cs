using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCollider : MonoBehaviour
{
    public static GreenCollider _instance;
    public int hittingObjectCount = 1;

    private void Awake()
    {
        _instance = this;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GreenCaseCollected")
        {
            Destroy(collision.gameObject);
            
            Finish._instance.MakeColored((((hittingObjectCount)*4)),Finish._instance.greenCaseColor);
            hittingObjectCount++;

        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
