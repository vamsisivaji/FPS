using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    float tim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tim = tim + Time.deltaTime;
        if(tim>3.0f)
        {
            Destroy(gameObject);
        }
    }
}
