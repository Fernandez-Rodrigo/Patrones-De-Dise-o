using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAttack : MonoBehaviour
{
    float speed = 5f;
    Transform target;
  

    public void Spawn(Transform startPos)
    {
        Instantiate(this, startPos);
    }


    public IEnumerator moveObject(Transform start, Transform end)
    {
      
        float totalMovementTime = 5f;
        float currentMovementTime = 0f;
     
        while (Vector3.Distance(this.transform.localPosition, end.position) > 0)
        {
            currentMovementTime += Time.deltaTime;
            transform.position = Vector3.Lerp(start.position, end.position, currentMovementTime / totalMovementTime);
            Debug.Log(Vector3.Distance(transform.localPosition, end.position));
            yield return null;
            
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this);
        }
    }
    public void MoveToTareget(Transform target)
    {        
         float step = speed * Time.deltaTime;
         transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        
    }

}
