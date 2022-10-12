using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float shootingForce = 10f;
    public Vector3 shootingDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(shootingDirection * shootingForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
