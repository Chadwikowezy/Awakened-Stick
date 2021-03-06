﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsManager : MonoBehaviour
{
    #region variables
    public Animator anim;
    public PlayerMovement leftButton, rightButton;
    public GameObject raycastObject;

    public GameObject arrowObj;
    public GameObject ascendingArrow;
    public GameObject vortexDischargeOBJ;
    public GameObject searingIgnitionEffect;
    public GameObject piercingFistOBJ;
    public GameObject scytheObj;
    public GameObject wrathOBJ;
    public GameObject spiralingTempestOBJ;
    public GameObject laceratingTyphoonOBJ;

    public GameObject permaFrostOBJ;

    int buttonL, buttonR, lRSum;

    public bool onGround;

    public bool usingShield;

    public bool usingSkill;
    public bool inMiddleOfSkillCast;

    private int damageMultiplier;
    private int basedamageMultiplier = 2;
    private Player player;

    private int jumpHeight = 15;

    private bool longCD;

    public int kickDamage;
    public int wrathsDamage;
    public int frostDamage;
    public int lacerateDamage;

    public int skillTier;

    public bool ascendingShot = false;
    #endregion

    void Start()
    {
        player = GetComponent<Player>();
    }
    void Update ()
    {
        Handle_Run_Idle();
    }

    void AnimationController(string animName)
    {
        anim.SetInteger("shield", 0);
        anim.SetInteger("frost", 0);
        anim.SetInteger("lacerate", 0);
        anim.SetInteger("wrath", 0);
        anim.SetInteger("tempest", 0);
        anim.SetInteger("jump", 0);
        anim.SetInteger("uncontrolled", 0);
        anim.SetInteger("arrow", 0);
        anim.SetInteger("scythe", 0);
        anim.SetInteger("ignition", 0);
        anim.SetInteger("ascending", 0);
        anim.SetInteger("vortex", 0);
        anim.SetInteger("kick", 0);
        anim.SetInteger("run", 0);
        anim.SetInteger("idle", 0);
        anim.SetInteger("fist", 0);
        anim.SetInteger(animName, 1);
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
            AnimationController("run");
        }
        else if (lRSum == 0 && onGround == true && usingShield == false && usingSkill == false)
        {
            //player run animation set to false
            AnimationController("idle");
        }
    }
    #endregion

    #region shield function and coroutine in here
    public void Shield()
    {
        //activate shield animation
        usingShield = true;
        AnimationController("shield");
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
            AnimationController("fist");
            StartCoroutine(PiercingFistDelay());
        }       
    }
    IEnumerator PiercingFistDelay()
    {
        yield return new WaitForSeconds(.6f);
        GameObject piercingFist = (GameObject)Instantiate(piercingFistOBJ, raycastObject.transform.position, raycastObject.transform.rotation);
        usingSkill = false;
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
            AnimationController("kick");
            StartCoroutine(HeavenPiercerDelay());
        }

    }
    IEnumerator HeavenPiercerDelay()
    {
        yield return new WaitForSeconds(.5f);
        Debug.Log("Before raycast");
        RaycastHit2D hit = Physics2D.Raycast(raycastObject.transform.position, raycastObject.transform.right);
        if (Physics2D.Raycast(raycastObject.transform.position, raycastObject.transform.right, 2f))
        {
            if (hit.collider.tag == "Enemy")
            {
                //deal damage

                //deal knockback
                damageMultiplier = ((player.CurrentRage + kickDamage) * skillTier);

                hit.collider.gameObject.GetComponent<Enemy>().AlterHealth(damageMultiplier);
                player.ReturnHealth(5 * skillTier);
                if (hit.collider.gameObject.transform.position.x < transform.position.x)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * 500);
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250);

                }
                else if (hit.collider.gameObject.transform.position.x > transform.position.x)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 500);
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250);
                }

            }
        }
        yield return new WaitForSeconds(.3f);
        usingSkill = false;
        Debug.Log("after raycast");
        inMiddleOfSkillCast = false;
    }
    #endregion

    #region Wraith's Destruction 01
    public void WraithsDestruction()
    {
        if (inMiddleOfSkillCast == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            AnimationController("wrath");
            StartCoroutine(WrathsDestructionDelay());
        }
    }
    IEnumerator WrathsDestructionDelay()
    {
        yield return new WaitForSeconds(.8f);
        damageMultiplier = ((player.CurrentRage + wrathsDamage) * skillTier);
        wrathOBJ.SetActive(true);
        wrathOBJ.GetComponent<ParticleSystem>().Play();

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                enemy.GetComponent<Enemy>().AlterHealth(damageMultiplier);
            }
        }
        yield return new WaitForSeconds(.4f);

        usingSkill = false;
        inMiddleOfSkillCast = false;
        wrathOBJ.SetActive(false);
    }
    #endregion

    #region Howling Scythe 01
    public void HowlingScythe()
    {
        if (inMiddleOfSkillCast == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            AnimationController("scythe");
            StartCoroutine(HowlingScytheDelay());
        }
    }
    IEnumerator HowlingScytheDelay()
    {
        yield return new WaitForSeconds(.8f);
        GameObject howlingScythe = (GameObject)Instantiate(scytheObj, raycastObject.transform.position, raycastObject.transform.rotation);

        yield return new WaitForSeconds(.3f);
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
            AnimationController("vortex");
            StartCoroutine(VortexDischargeDelay());
        }
    }
    IEnumerator VortexDischargeDelay()
    {
        yield return new WaitForSeconds(.6f);
        GameObject spell = (GameObject)Instantiate(vortexDischargeOBJ, raycastObject.transform.position, raycastObject.transform.rotation);
        usingSkill = false;
        inMiddleOfSkillCast = false;
    }
    #endregion

    #region Searing Ignition 01
    public void SearingIgnition()
    {
        if (inMiddleOfSkillCast == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            AnimationController("ignition");

            StartCoroutine(SearingIgnitionDelay());
        }
    }
    IEnumerator SearingIgnitionDelay()
    {
        yield return new WaitForSeconds(2f);
        searingIgnitionEffect.SetActive(true);
        usingSkill = false;
        inMiddleOfSkillCast = false;
    }
    #endregion

    #region Permafrost 01
    public void Permafrost()
    {
        if (inMiddleOfSkillCast == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            AnimationController("frost");
            StartCoroutine(PermafrostDelay());
        }
    }
    IEnumerator PermafrostDelay()
    {
        damageMultiplier = ((player.CurrentArcane + frostDamage) * skillTier);
        permaFrostOBJ.SetActive(true);
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(1f);
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in enemies)
            {
                if (enemy != null)
                {
                    enemy.GetComponent<Enemy>().AlterHealth(damageMultiplier / 2);
                }
            }
        }
        usingSkill = false;
        inMiddleOfSkillCast = false;
        permaFrostOBJ.SetActive(false);

    }

    #endregion

    #region Spiraling Tempest 01
    public void SpiralingTempest()
    {
        if (inMiddleOfSkillCast == false && longCD == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            longCD = true;
            AnimationController("tempest");
            StartCoroutine(SpiralingTempestDelay());
        }
    }
    IEnumerator SpiralingTempestDelay()
    {
        spiralingTempestOBJ.SetActive(true);
        player.tag = "Untagged";

        yield return new WaitForSeconds(3f * skillTier);
        player.tag = "Player";
        usingSkill = false;
        inMiddleOfSkillCast = false;
        spiralingTempestOBJ.SetActive(false);
        yield return new WaitForSeconds(2f);
        longCD = false;
    }
    #endregion

    #region Piercing Shot 01
    public void PiercingShot()
    {
        if (inMiddleOfSkillCast == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            AnimationController("arrow");


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

    #region Uncontrolled Speed 01
    public void UncontrolledSpeed()
    {
        if (inMiddleOfSkillCast == false && longCD == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            longCD = true;
            AnimationController("uncontrolled");
            StartCoroutine(UncontrolledSpeedDelay());
        }
    } 
    IEnumerator UncontrolledSpeedDelay()
    {
        yield return new WaitForSeconds(.2f);
        if (anim.gameObject.transform.eulerAngles.y == 180 && player.transform.position.x > -45)
        {
            player.transform.position = new Vector3((player.transform.position.x - (5 * skillTier)), player.transform.position.y, player.transform.position.z);
        }
        else if (anim.gameObject.transform.eulerAngles.y == 0 && player.transform.position.x < 45)
        {
            player.transform.position = new Vector3((player.transform.position.x + (5 * skillTier)), player.transform.position.y, player.transform.position.z);
        }
        usingSkill = false;
        inMiddleOfSkillCast = false;

        yield return new WaitForSeconds(1f);

        longCD = false;
    }
    #endregion

    #region Lacerating Typhoon 01
    public void LaceratingTyphoon()
    {
        if (inMiddleOfSkillCast == false)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            AnimationController("lacerate");


            StartCoroutine(LaceratingTyphoonDelay());
        }
    }
    IEnumerator LaceratingTyphoonDelay()
    {
        yield return new WaitForSeconds(.6f);
        //laceratingTyphoonOBJ.SetActive(true);
        for(int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(.4f);
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            damageMultiplier = (player.CurrentSpeed + lacerateDamage) *skillTier;
            foreach (GameObject enemy in enemies)
            {
                if (Vector2.Distance(transform.position, enemy.transform.position) <= 4)
                {
                    enemy.GetComponent<Enemy>().AlterHealth(damageMultiplier);
                }
            }
        }
        
        yield return new WaitForSeconds(.3f);
        //laceratingTyphoonOBJ.SetActive(false);
        usingSkill = false;
        inMiddleOfSkillCast = false;
    }
    #endregion

    #region Ascending Shot 01
    public void AscendingShot()
    {
        if (inMiddleOfSkillCast == false && longCD == false && onGround == true)
        {
            usingSkill = true;
            inMiddleOfSkillCast = true;
            longCD = true;
            onGround = false;
            AnimationController("ascending");
            ascendingShot = true;
            StartCoroutine(AscendingShotDelay());
        }
    }
    IEnumerator AscendingShotDelay()
    {
        player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);

        if (anim.gameObject.transform.eulerAngles.y == 180 && player.transform.position.x > -45)
        {
            player.GetComponent<Rigidbody2D>().AddForce(Vector2.right * jumpHeight, ForceMode2D.Impulse);
        }
        else if (anim.gameObject.transform.eulerAngles.y == 0 && player.transform.position.x < 45)
        {
            player.GetComponent<Rigidbody2D>().AddForce(Vector2.left * jumpHeight, ForceMode2D.Impulse);
        }

        yield return new WaitForSeconds(1f);
        GameObject arrow = (GameObject)Instantiate(ascendingArrow, raycastObject.transform.position, raycastObject.transform.rotation);
        yield return new WaitForSeconds(.2f);

        usingSkill = false;
        inMiddleOfSkillCast = false;
        ascendingShot = false;
        yield return new WaitForSeconds(2f);
        longCD = false;

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
        if(obj.gameObject.tag == "Ground" && ascendingShot == false)
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

