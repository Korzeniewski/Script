﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour
{
    public Transform target;
    public GameObject player;
    private Vector3 offset;
    public bool camera_tru = true;
    public bool cameraV = false;
    public bool cameraH = false;
    public LayerMask whatIsColliderV;
    public LayerMask whatIsColliderH;
    public LayerMask whatIsColliderHV;
    public GameObject playerbody;
    public Collider2D myColider;
    private Vector2 velocity;
    public float smoothTimeY;
    public float smoothTimeX;
    public float cameraUpY;
    
    void Start()
    {
        offset = transform.position - player.transform.position;
        myColider = playerbody.GetComponent<Collider2D>(); 
}

    private void FixedUpdate()
    {

        if (camera_tru)
        {
           
            float posx = Mathf.SmoothDamp(transform.position.x,player.transform.position.x,ref velocity.x, smoothTimeX);
            float posy = Mathf.SmoothDamp(transform.position.y, player.transform.position.y+cameraUpY, ref velocity.y, smoothTimeY);
            transform.position = new Vector3(posx,posy,transform.position.z);
        }
        else if (!camera_tru && cameraV)
        {
            
            float posy = Mathf.SmoothDamp(transform.position.y, player.transform.position.y + cameraUpY, ref velocity.y, smoothTimeY);
            float setPosition = transform.position.x;
            transform.position = new Vector3(setPosition, posy, transform.position.z);
        }
        else if (!camera_tru && cameraH)
        {
            float posx = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
            
            float setPosition = transform.position.y;
            transform.position = new Vector3(posx, setPosition, transform.position.z);
        }



        if (Physics2D.IsTouchingLayers(myColider, whatIsColliderH))
        {
            camera_tru = false;
            cameraH = true;
            cameraV = false;
        }
        else if (Physics2D.IsTouchingLayers(myColider, whatIsColliderV))
        {
            camera_tru = false;
            cameraV = true;
            cameraH = false;
        }
        else if (Physics2D.IsTouchingLayers(myColider, whatIsColliderHV))
        {
            camera_tru = false;
            cameraV = false;
            cameraH = false;
            
        }
        else
        {
            cameraV = false;
            cameraH = false;
            camera_tru = true;
        }
    }
}