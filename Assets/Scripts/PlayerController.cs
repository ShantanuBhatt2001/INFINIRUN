using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Variables")]
    [SerializeField] float minMovSpeed;
    [SerializeField] float acceleration;
    [SerializeField] float maxMoveSpeed;
    [Header("FireVariables")]
    
    [SerializeField] GameObject bulletPrefab;
    [SerializeField]Transform firePoint;


    //Private Vars

    Rigidbody rb;
    [SerializeField]float currMoveSpeed;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        currMoveSpeed=minMovSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+=transform.right*currMoveSpeed*Time.deltaTime;
        SpeedUpdate();
        if(Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
    }



    void FireBullet()
    {
        GameObject bullet=Instantiate(bulletPrefab,firePoint.position,Quaternion.identity);
        
    }


    void SpeedUpdate()
    {
        if(currMoveSpeed<maxMoveSpeed)
        currMoveSpeed+=acceleration*Time.deltaTime;


    }
}
