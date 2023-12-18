using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformscript : MonoBehaviour
{

    Rigidbody cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            cube.AddForce(new Vector3(-2, 0, 0));
            //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            cube.AddForce(new Vector3(2, 0, 0));
        }

    }
}
