using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAfterInstantiated : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(KillSelf());
    }
    void Update ()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 4f);	
	}

    IEnumerator KillSelf()
    {
        yield return new WaitForSeconds(4f);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
