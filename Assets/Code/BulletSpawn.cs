using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    static int counter=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (counter < 10)
            {
                GameObject BulletReference=Instantiate(bullet);
                BulletReference.transform.position = transform.position;
                Rigidbody rb = BulletReference.GetComponent<Rigidbody>();
                rb.velocity = transform.rotation*Vector3.forward * 50.0f;
                counter++;
            }
            else 
            {
                print("out of bullets");
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            counter = 0;
        }
    }
}
