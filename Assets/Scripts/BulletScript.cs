using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField] float bulletSpeed=100f;
   private void Update() {
    transform.position+=transform.right*bulletSpeed*Time.deltaTime;
   }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="Wall")
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic=false;
        }
    }
}
