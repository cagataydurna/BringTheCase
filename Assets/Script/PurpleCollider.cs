using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleCollider : MonoBehaviour
{
    public static PurpleCollider _instance;
    public int hittingObjectCount = 1;
    private void Awake()
    {
        _instance = this;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PurpleCaseCollected")
        {
            Destroy(collision.gameObject);
           
            Finish._instance.MakeColored(((hittingObjectCount) * 4)+3,Finish._instance.purpleCaseColor);

            hittingObjectCount++;

            
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
