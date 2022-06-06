using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedObjectMovement : MonoBehaviour
{
    public bool isFinish;
    void Start()
    {
        isFinish = PlayerMovement._instance.isFinish;
    }

    // Update is called once per frame
    void Update()
    {
        isFinish = PlayerMovement._instance.isFinish;
        if (isFinish)
        {
            transform.Translate(new Vector3(0,0,Time.deltaTime*5f));
        }
    }
}
