using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [Range (5000f,50000f)] [SerializeField] float Speed=1000f;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 movement = new Vector3(0, 0, 1*Speed*Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {

            //rigidbody.MovePosition(transform.position + movement);
            rigidbody.AddForce(0,0,10*Speed*Time.deltaTime);
            
        }
    }
}
