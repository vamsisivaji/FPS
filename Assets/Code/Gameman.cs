using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameman : MonoBehaviour
{
    float time = 10.0f;
    public Text timetext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime;
        if(time<=0)
        {
            SceneManager.LoadScene(0);
        }
        timetext.text = time.ToString();
    }
}
