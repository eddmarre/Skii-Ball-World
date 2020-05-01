using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTirgger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject skiiBall;
    [SerializeField] GameObject text;
    void Start()
    {
        //skiiBall = GetComponent<GameObject>();
        skiiBall.SetActive(false);
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //print("enter");
        skiiBall.SetActive(true);
        text.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
       // print("exit");
        skiiBall.SetActive(false);
        text.SetActive(false);
        
    }
}
