using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCollider : MonoBehaviour
{
    public static BlueCollider _instance;
    public int hittingObjectCount = 1;
    private void Awake()
    {
        _instance = this;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BlueCaseCollected")
        {
            Destroy(collision.gameObject);
            
            Finish._instance.MakeColored(((hittingObjectCount) * 4)+2,Finish._instance.blueCaseColor);

            hittingObjectCount++;
            
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
