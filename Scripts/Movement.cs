using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [Range(1f, 100f)] [SerializeField] float speed=40f;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed + 40f;
            
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed - 40f;
        }
         Vector3 movement = new Vector3(Horizontal * speed * Time.deltaTime, 0, Vertical * speed * Time.deltaTime);
        rigidbody.MovePosition(transform.position + movement);
        //transform.Translate(movement);

    }
}
