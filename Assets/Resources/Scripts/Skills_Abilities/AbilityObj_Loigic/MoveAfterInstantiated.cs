using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAfterInstantiated : MonoBehaviour
{
    public float objMoveSpeed;

    private void Start()
    {
        StartCoroutine(KillSelf());
    }
    void Update ()
    {
        transform.Translate(Vector3.right * Time.deltaTime * objMoveSpeed);	
        if(tag == "AscendingShot")
        {
            transform.Translate(Vector3.down * Time.deltaTime * 4);

        }
    }

    IEnumerator KillSelf()
    {
        yield return new WaitForSeconds(4f);
        Destroy(this.gameObject);
    }

    
}
