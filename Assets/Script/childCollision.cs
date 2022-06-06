using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childCollision : MonoBehaviour
{
    public void OnTriggerExit(Collider other)
    {
        if (
            other.gameObject.tag == "BlueCase"
            || other.gameObject.tag == "RedCase"
            || other.gameObject.tag == "GreenCase"
            || other.gameObject.tag == "PurpleCase")
        {
            Vibration.Init();
            Vibration.VibratePop();
            other.gameObject.transform.position = transform.position + Vector3.forward;
            Destroy(gameObject.GetComponent<Collect>());
            other.gameObject.AddComponent<Collect>();
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.AddComponent<Node>();
            other.gameObject.transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
            other.gameObject.GetComponent<Node>().nodePosition = transform;
            if (other.gameObject.tag == "BlueCase") other.gameObject.tag = "BlueCaseCollected";
            else if (other.gameObject.tag == "RedCase") other.gameObject.tag = "RedCaseCollected";
            else if (other.gameObject.tag == "PurpleCase")
                other.gameObject.tag = "PurpleCaseCollected";
            else if (other.gameObject.tag == "GreenCase") other.gameObject.tag = "GreenCaseCollected";
        }    }
}
