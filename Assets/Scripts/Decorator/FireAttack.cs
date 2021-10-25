using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAttack : MonoBehaviour
{
    float speed = 50f;
    public Transform target;


    public void Spawn(Transform startPos)
    {
        Instantiate(this, startPos);
           
    }

    private void Update()
    {
        MoveToTareget(target);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Target")
        {
            Destroy(this.gameObject);
        }
    }

    public void MoveToTareget(Transform target)
    {        
         float step = speed * Time.deltaTime;
         transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

}
