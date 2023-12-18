using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class hp : MonoBehaviour
{
    Rigidbody myRigidbody;
    [SerializeField]
    GameObject HP1;
    [SerializeField]
    GameObject HP2;
    [SerializeField]
    GameObject HP3;
    int liv = 3;
    // Start is called before the first frame update

    public void TakeDamage()
    {
        liv -= 1;
        if (liv == 0)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
       
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.AddForce(new Vector3(0, -1, 0));
    }

    // Update is called once per frame
    public void Update()
    {
        float speed = 8;
        myRigidbody.velocity = myRigidbody.velocity.normalized * speed;
        float timer = 4;
        
        timer -= Time.deltaTime;
        if (transform.position.y < -6)
        {
            timer = 4f;
            liv--;
            transform.position = new Vector3(0, 0, 0);
            
            if (liv == 2)
            {
                Destroy (HP1);
            }
            
            if (liv == 1)
            {
                Destroy(HP3);
            }
            
            if (liv == 0)
            {
                Destroy(HP2);
            }
        }
    }
}
