using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Start is called before the first frame update

    public float speed = 20.0f;
    public float turnSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
   
   

    void Update()
    {
        //Moving vehicle forward

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);

    }
}
