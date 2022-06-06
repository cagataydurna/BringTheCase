using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Update()
    {
        transform.position=Vector3.Lerp(transform.position,player.position+offset,Time.deltaTime*4);
        if (PlayerMovement._instance.isFinish)
        {
            offset.y += Time.deltaTime ;
            offset.x = 0;
        }
    }
}
