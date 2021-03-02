using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreT;
    int Sc=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ScoreMan(int val)
    {
        Sc = Sc + val;
        print("score: "+Sc);
        ScoreT.text = Sc.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
