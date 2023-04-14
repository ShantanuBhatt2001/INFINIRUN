using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyDens : MonoBehaviour
{
    [SerializeField] private float density=5f;
    void Start()
    {
        GetComponent<Rigidbody>().SetDensity(density);
        GetComponent<Rigidbody>().mass=GetComponent<Rigidbody>().mass;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
