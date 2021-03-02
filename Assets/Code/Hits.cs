using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hits : MonoBehaviour
{
    int Hit = 1;
    private void OnCollisionEnter(Collision collision)
    {
        Score scoreKeeper = FindObjectOfType<Score>();
        scoreKeeper.ScoreMan(Hit);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
