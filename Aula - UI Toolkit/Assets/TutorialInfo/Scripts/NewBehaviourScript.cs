using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0,speed*Time.deltaTime,0, Space.World);
        transform.rotation = Quaternion.Euler(0, speed * Time.deltaTime, 0);
    }
}
