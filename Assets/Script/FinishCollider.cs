using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FinishCollider : MonoBehaviour
{
   public GameObject collectedObject;
   
   private void OnCollisionEnter(Collision collision)
   {
      this.gameObject.GetComponent<BoxCollider>().enabled = false;
     
      collectedObject.transform.parent = null;
      collectedObject.transform.position = new Vector3(0, 1.5f, collectedObject.transform.position.z);
      PlayerMovement._instance.isFinish = true;
      
   }

    void Update()
   {
       if (collectedObject.transform.position.z > transform.position.z+15)
       {
           PlayerMovement._instance.isFinishForCanvas = true;
       }
   }
}
