using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreKeeper;
    [Range (1f,25f)]public int points;
    static int scoreTracker=0;
    
    void Start()
    {
        scoreKeeper.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag=="ball")
        {
            scoreTracker += points;
            scoreKeeper.text = scoreTracker.ToString();
        }
        
    }
    
}
