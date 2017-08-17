using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierManager : MonoBehaviour
{
    private Player player;
    public GameObject[] leftSideBarrier;
    public GameObject[] rightSideBarrier;

    public GameObject leftBarrier;
    public GameObject rightBarrier;

	void Start ()
    {
        player = FindObjectOfType<Player>();
    }

    void BarrierEnabler()
    {
        if(player.transform.position.x <= -30)
        {
            foreach(GameObject barrier in leftSideBarrier)
            {
                barrier.SetActive(true);
            }
        } 
        else if (player.transform.position.x > -30)
        {
            foreach (GameObject barrier in leftSideBarrier)
            {
                barrier.SetActive(false);
            }
        }
        if (player.transform.position.x > 30)
        {
            foreach (GameObject barrier in rightSideBarrier)
            {
                barrier.SetActive(true);
            }
        }
        else if (player.transform.position.x < 30)
        {
            foreach (GameObject barrier in rightSideBarrier)
            {
                barrier.SetActive(false);
            }
        }
    }

    public void BarrierDamageManager()
    {
        if (player.transform.position.x >= 50)
        {
            rightBarrier.SetActive(true);
            StartCoroutine(returnBarrier());
        }
        else if (player.transform.position.x <= -50)
        {
            leftBarrier.SetActive(true);
            StartCoroutine(returnBarrier());
        }
        else if (player.transform.position.x >= 60)
        {
            player.AlterHealth(100);
        }
        else if (player.transform.position.x <= -60)
        {
            player.AlterHealth(100);
        }
    }

    

    IEnumerator returnBarrier()
    {
        yield return new WaitForSeconds(1f);
        rightBarrier.SetActive(false);
        leftBarrier.SetActive(false);
        yield return new WaitForSeconds(1f);
        rightBarrier.SetActive(true);
        leftBarrier.SetActive(true);
    }

    void Update ()
    {
        BarrierEnabler();
        BarrierDamageManager();
    }
}
