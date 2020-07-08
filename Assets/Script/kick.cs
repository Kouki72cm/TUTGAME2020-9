using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick : MonoBehaviour
{
    Transform target;
    float speed = 1f;
    float step;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N)) {
                step = speed * Time.deltaTime;
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 360f, 0), step);
        }
    }
}
