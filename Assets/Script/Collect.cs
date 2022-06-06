
using System;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public RaycastHit hit;

    void Awake()
    {
        Vibration.Init();
        
    }

    void Start()
    {
       
    }

    void Update()
    {
CheckCollision();    
    }

    public void CheckCollision()
    {
        if (Physics.Raycast(transform.position, transform.position + Vector3.forward, out hit, 1f))
        {
            if (
                hit.transform.tag == "BlueCase"
                || hit.transform.tag == "RedCase"
                || hit.transform.tag == "GreenCase"
                || hit.transform.tag == "PurpleCase")
            {
                Vibration.Init();
                Vibration.VibratePop();
                hit.transform.position = transform.position + Vector3.forward;
                Destroy(gameObject.GetComponent<Collect>());
                hit.collider.gameObject.AddComponent<Collect>();
                hit.collider.gameObject.GetComponent<BoxCollider>().isTrigger = false;
                hit.collider.gameObject.AddComponent<Node>();
                hit.collider.gameObject.transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
                hit.collider.gameObject.GetComponent<Node>().nodePosition = transform;
                if (hit.collider.gameObject.tag == "BlueCase") hit.collider.gameObject.tag = "BlueCaseCollected";
                else if (hit.collider.gameObject.tag == "RedCase") hit.collider.gameObject.tag = "RedCaseCollected";
                else if (hit.collider.gameObject.tag == "PurpleCase")
                    hit.collider.gameObject.tag = "PurpleCaseCollected";
                else if (hit.collider.gameObject.tag == "GreenCase") hit.collider.gameObject.tag = "GreenCaseCollected";
            }


        }
        
    }

    
}
