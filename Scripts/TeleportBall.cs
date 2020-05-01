using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBall : MonoBehaviour
{
    public GameObject skiiball;
    public GameObject teleportLocation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
            skiiball.transform.position = teleportLocation.transform.position;
        
    }
}
