using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClampName : MonoBehaviour
{
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make sure camera is tagged main VVVVVVVV
        Vector3 namepos = Camera.main.WorldToScreenPoint(this.transform.position);
        Score.transform.position = namepos;
    }
}
