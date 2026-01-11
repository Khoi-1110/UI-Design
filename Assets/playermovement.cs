using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kk : MonoBehaviour
{
    public float speed = 10.5f;
    // Start is called before the first frame update
    void Start()
    {
        print("Lets do this");
    }

    // Update is called once per frame
    void Update()
    {
   
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            //Time.deltaTine is 1 sec
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            //Time.deltaTine is 1 sec
        }
    }
}
