using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsManager : MonoBehaviour
{
    public Animator anim;
    public PlayerMovement leftButton, rightButton;
    public GameObject raycastObject;

    public GameObject arrowObj;
    public GameObject spellObj;

    int buttonL, buttonR, lRSum;

    public bool onGround;

    public bool usingShield;

    public bool usingSkill;
    public bool inMiddleOfSkillCast;
 
    void Update ()
    {
        Handle_Run_Idle();
    }

    #region handle running/ idle animations
    public void Handle_Run_Idle()
    {
        buttonL = leftButton.isOn;
        buttonR = rightButton.isOn;

        lRSum = buttonL + buttonR;

        if (lRSum > 0 && onGround == true && usingShield == false && usingSkill == false)
        {
            //player run animation set to true
            anim.SetInteger("idle", 0);
            anim.SetInteger("shield", 0);
            anim.SetInteger("jump", 0);
            anim.SetInteger("arrow", 0);
            anim.SetInteger("spell", 0);
            anim.SetInteger("punch", 0);
            anim.SetInteger("Kick", 0);
            anim.SetInteger("run", 1);
        }
        else if (lRSum == 0 && onGround == true && usingShield == false && usingSkill == false)
        {
            //player run animation set to false
            anim.SetInteger("run", 0);
            anim.SetInteger("shield", 0);
            anim.SetInteger("jump", 0);
            anim.SetInteger("arrow", 0);
            anim.SetInteger("punch", 0);
            anim.SetInteger("spell", 0);
            anim.SetInteger("Kick", 0);
            anim.SetInteger("idle", 1);
        }
    }
    #endregion

    #region shield function and coroutine in here
    public void Shield()
    {
        //activate shield animation
        usingShield = true;
        anim.SetInteger("idle", 0);
        anim.SetInteger("run", 0);
        anim.SetInteger("jump", 0);
        anim.SetInteger("spell", 0);
        anim.SetInteger("arrow", 0);
        anim.SetInteger("punch", 0);
        anim.SetInteger("Kick", 0);
        anim.SetInteger("shield", 1);
        Debug.Log("Shield");
        StartCoroutine(OnShieldRelease());
    }
    public IEnumerator OnShieldRelease()
    {
        yield return new WaitForSeconds(2);
        anim.SetInteger("shield", 0);
        usingShield = false;
        anim.SetInteger("idle", 1);
    }
    #endregion

    #region Piercing Fist 01
    public void PiercingFist()
    {
        if(inMiddleOfSkillCast == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            anim.SetInteger("run", 0);
            anim.SetInteger("spell", 0);
            anim.SetInteger("shield", 0);
            anim.SetInteger("jump", 0);
            anim.SetInteger("arrow", 0);
            anim.SetInteger("Kick", 0);
            anim.SetInteger("idle", 0);
            anim.SetInteger("punch", 1);

            StartCoroutine(PiercingFistDelay());
        }       
    }
    IEnumerator PiercingFistDelay()
    {
        yield return new WaitForSeconds(.5f);
        Debug.Log("Before raycast");
        RaycastHit2D hit = Physics2D.Raycast(raycastObject.transform.position, raycastObject.transform.right);
        if(Physics2D.Raycast(raycastObject.transform.position, raycastObject.transform.right, 1f))
        {
            if (hit.collider.tag == "Enemy")
            {
                //deal damage

                //deal knockback
                if (hit.collider.gameObject.transform.position.x < transform.position.x)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * 800);
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 400);

                }
                else if (hit.collider.gameObject.transform.position.x > transform.position.x)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 800);
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 400);
                }
            }
        }    
        yield return new WaitForSeconds(.3f);
        usingSkill = false;
        Debug.Log("after raycast");
        inMiddleOfSkillCast = false;

    }
    #endregion

    #region Heaven Piercer 01
    public void HeavenPiercer()
    {
        if (inMiddleOfSkillCast == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            anim.SetInteger("run", 0);
            anim.SetInteger("shield", 0);
            anim.SetInteger("jump", 0);
            anim.SetInteger("spell", 0);
            anim.SetInteger("idle", 0);
            anim.SetInteger("arrow", 0);
            anim.SetInteger("punch", 0);
            anim.SetInteger("Kick", 1);

            StartCoroutine(HeavenPiercerDelay());
        }

    }
    IEnumerator HeavenPiercerDelay()
    {
        yield return new WaitForSeconds(.5f);
        Debug.Log("Before raycast");
        RaycastHit2D hit = Physics2D.Raycast(raycastObject.transform.position, raycastObject.transform.right);
        if (Physics2D.Raycast(raycastObject.transform.position, raycastObject.transform.right, 1f))
        {
            if (hit.collider.tag == "Enemy")
            {
                //deal damage

                //deal knockback
                if (hit.collider.gameObject.transform.position.x < transform.position.x)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * 800);
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 400);

                }
                else if (hit.collider.gameObject.transform.position.x > transform.position.x)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 800);
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 400);
                }

            }
        }
        yield return new WaitForSeconds(.3f);
        usingSkill = false;
        Debug.Log("after raycast");
        inMiddleOfSkillCast = false;
    }
    #endregion

    #region Piercing Shot 01
    public void PiercingShot()
    {
        if (inMiddleOfSkillCast == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            anim.SetInteger("run", 0);
            anim.SetInteger("shield", 0);
            anim.SetInteger("jump", 0);
            anim.SetInteger("idle", 0);
            anim.SetInteger("spell", 0);
            anim.SetInteger("punch", 0);
            anim.SetInteger("Kick", 0);
            anim.SetInteger("arrow", 1);

            StartCoroutine(PiercingShotDelay());
        }
    }
    IEnumerator PiercingShotDelay()
    {
        yield return new WaitForSeconds(.6f);
        GameObject arrow = (GameObject)Instantiate(arrowObj, raycastObject.transform.position, raycastObject.transform.rotation);
        usingSkill = false;
        inMiddleOfSkillCast = false;
    }
    #endregion

    #region Vortex Discharge 01
    public void VortexDischarge()
    {
        if (inMiddleOfSkillCast == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            anim.SetInteger("run", 0);
            anim.SetInteger("shield", 0);
            anim.SetInteger("jump", 0);
            anim.SetInteger("idle", 0);
            anim.SetInteger("punch", 0);
            anim.SetInteger("Kick", 0);
            anim.SetInteger("arrow", 0);
            anim.SetInteger("spell", 1);

            StartCoroutine(VortexDischargeDelay());
        }
    }
    IEnumerator VortexDischargeDelay()
    {
        yield return new WaitForSeconds(.6f);
        GameObject spell = (GameObject)Instantiate(spellObj, raycastObject.transform.position, raycastObject.transform.rotation);
        usingSkill = false;
        inMiddleOfSkillCast = false;
    }
    #endregion

    #region Handle Jumping/ Idle animations aka on collision stay and exit
    void OnCollisionEnter2D(Collision2D obj)
    {
        if(obj.gameObject.tag == "Ground")
        {
            //set jumping anim to false
            anim.SetInteger("jump", 0);
            onGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D obj)
    {
        if(obj.gameObject.tag == "Ground")
        {
            //running anim to false
            anim.SetInteger("run", 0);
            anim.SetInteger("idle", 0);
            //jump anim to true
            anim.SetInteger("jump", 1);
            onGround = false;
        }
    }
    #endregion
}

