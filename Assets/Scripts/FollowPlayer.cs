using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // adds a player variable, visible in inspector
    [SerializeField] Vector3 offset = new Vector3(0, 6, -8);
    private Vector3 firstPersonOffset = new Vector3(0, 1.85f, 2.5f);
    private Boolean firstPersonCamera = false;
    public String InputID;
       // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame. Late update lets vehicle move first, which smoothes the camera follow
    void LateUpdate()
    {
        if(Input.GetButtonDown("Cam" + InputID))
        { 
            if (firstPersonCamera)
            {
                firstPersonCamera = false;
            }
            else
            {
                firstPersonCamera = true;
            }
        }
        //change camera if user presses space/jump
        if (firstPersonCamera)
        {
            //offset to first person camera
            transform.position = player.transform.position + firstPersonOffset;
            transform.rotation = player.transform.rotation;
        }
        else
        {
        // offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset; 
        }
    }
}
