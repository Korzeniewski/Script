using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemFollow : MonoBehaviour
{

    public float speed;
    public GameObject targetd;
    void awaken()
    {
        targetd = GameObject.FindGameObjectWithTag("hero");
        
    }

    
    void Update()
    {
        var target = targetd.GetComponent<Transform>();
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
