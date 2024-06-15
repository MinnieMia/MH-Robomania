using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemMov : MonoBehaviour
{
    public float yForce;
    private Rigidbody2D enemyRigidBody;

    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
      
        {
            if (transform.position.x <= -8)
            {
                
            }
             if (transform.position.x >= 8)
            {
               
            }
                 
        }
      private void OnCollisionEnter2D(Collision2D collision)
        {
            
        }
    
    
}
