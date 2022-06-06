using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement _instance;
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float horizontalSpeed = 5f;
    public float leftClamp;
    public float rightClamp;
    public bool isFinish;
    public bool isPause;
    public bool isFinishForCanvas;
    
    
    public Touch theTouch;
    
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFinish&&!isPause)
        {


            transform.Translate(Vector3.forward * movementSpeed*Time.deltaTime);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.4f, 7.4f), transform.position.y,
                transform.position.z);
            if (Input.touchCount > 0)
            {
                theTouch = Input.GetTouch(0);
                if (theTouch.phase == TouchPhase.Moved)
                {
                    transform.position = new Vector3(transform.position.x + theTouch.deltaPosition.x *Time.deltaTime* horizontalSpeed,
                        transform.position.y, transform.position.z);
                }

            }
        }
    }
}
