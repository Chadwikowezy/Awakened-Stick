using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : TouchManager
{
    #region variables
    //touchbuttons
    public enum type
    {
        LeftButton, RightButton, JumpButton, ShieldButton,
        PiercingFist_01, HeavenPiercer_01, WraithsDestruction_01, HowlingScythe_01,
        VortexDischarge_01, SearingIgnition_01, Permafrost_01, SpiralingTempest_01,
        PiercingShot_01, UncontrolledSpeed_01, LaceratingTyphoon_01, AscendingShot_01,
        PiercingFist_02, HeavenPiercer_02, WraithsDestruction_02, HowlingScythe_02,
        VortexDischarge_02, SearingIgnition_02, Permafrost_02, SpiralingTempest_02,
        PiercingShot_02, UncontrolledSpeed_02, LaceratingTyphoon_02, AscendingShot_02
    };
    public type buttonType;


    public GameObject playerObj = null;
    Rigidbody2D playerRigidBody = null;

    public GUITexture buttonTexture;

    public float jumpHeight = 0;
    public float moveSpeed = 0;
    //both touch and pc movement
    public int isOn = 0;

    public GameObject playerAnimObject;

    private AnimationsManager animManager;
    #endregion

    void Start ()
    {
        animManager = FindObjectOfType<AnimationsManager>();
        playerRigidBody = playerObj.GetComponent<Rigidbody2D>();
        buttonTexture.transform.position = transform.position;
        playerAnimObject.transform.position = playerRigidBody.transform.position;
    }

    void Update ()
    {
        TouchInput(buttonTexture);
    }

    #region on first touch began for jump, shield, skill01, skill02, skill03
    void OnFirstTouchBegan()
    {
        switch (buttonType)
        {
            case type.JumpButton:
                if (playerObj.GetComponent<AnimationsManager>().onGround)
                {
                    playerRigidBody.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                }
                break;
        }
        switch (buttonType)
        {
            case type.ShieldButton:
                animManager.Shield();//currently does nothing
                break;
        }
        switch (buttonType)
        {
            case type.PiercingFist_01:
                animManager.PiercingFist();
                break;
        }
        switch (buttonType)
        {
            case type.HeavenPiercer_01:
                animManager.HeavenPiercer();
                break;
        }
        switch (buttonType)
        {
            case type.WraithsDestruction_01:
                //sword stab ground mass aoe
                break;
        }
        switch (buttonType)
        {
            case type.HowlingScythe_01:
                //sword slash lane based
                break;
        }
        switch (buttonType)
        {
            case type.VortexDischarge_01:
                animManager.VortexDischarge();
                break;
        }
        switch (buttonType)
        {
            case type.SearingIgnition_01:
                animManager.SearingIgnition();
                break;
        }
        switch (buttonType)
        {
            case type.Permafrost_01:
                //Huge aoe ice sickle rain down on foes
                break;
        }
        switch (buttonType)
        {
            case type.SpiralingTempest_01:
                //whirlwind sphere surronds player take no damage
                break;
        }
        switch (buttonType)
        {
            case type.PiercingShot_01:
                animManager.PiercingShot();
                break;
        }
        switch (buttonType)
        {
            case type.UncontrolledSpeed_01:
                //dash forward
                break;
        }
        switch (buttonType)
        {
            case type.LaceratingTyphoon_01:
                //blade spin in circle, AOE based but not as big of range as other AOE based skills
                break;
        }
        switch (buttonType)
        {
            case type.AscendingShot_01:
                //do a jump back and up, shoot arrows down lane you jump away from
                break;
        }
        switch (buttonType)
        {
            case type.PiercingFist_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.HeavenPiercer_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.WraithsDestruction_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.HowlingScythe_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.VortexDischarge_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.SearingIgnition_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.Permafrost_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.SpiralingTempest_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.PiercingShot_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.UncontrolledSpeed_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.LaceratingTyphoon_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.AscendingShot_02:
                //second tier of this skill
                break;
        }
    }
    #endregion

    #region on second touch began for jump, shield, skill01, skill02, skill03
    void OnSecondTouchBegan()
    {
        switch (buttonType)
        {
            case type.JumpButton:
                if (playerObj.GetComponent<AnimationsManager>().onGround)
                {
                    playerRigidBody.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                    Debug.Log("jump");
                }
                break;
        }
        switch (buttonType)
        {
            case type.ShieldButton:
                animManager.Shield();//does nothing atm
                break;
        }
        switch (buttonType)
        {
            case type.PiercingFist_01:
                animManager.PiercingFist();
                break;
        }
        switch (buttonType)
        {
            case type.HeavenPiercer_01:
                animManager.HeavenPiercer();
                break;
        }
        switch (buttonType)
        {
            case type.WraithsDestruction_01:
                //sword stab ground mass aoe
                break;
        }
        switch (buttonType)
        {
            case type.HowlingScythe_01:
                //sword slash lane based
                break;
        }
        switch (buttonType)
        {
            case type.VortexDischarge_01:
                animManager.VortexDischarge();
                break;
        }
        switch (buttonType)
        {
            case type.SearingIgnition_01:
                animManager.SearingIgnition();
                break;
        }
        switch (buttonType)
        {
            case type.Permafrost_01:
                //Huge aoe ice sickle rain down on foes
                break;
        }
        switch (buttonType)
        {
            case type.SpiralingTempest_01:
                //whirlwind sphere surronds player take no damage
                break;
        }
        switch (buttonType)
        {
            case type.PiercingShot_01:
                animManager.PiercingShot();
                break;
        }
        switch (buttonType)
        {
            case type.UncontrolledSpeed_01:
                //dash forward
                break;
        }
        switch (buttonType)
        {
            case type.LaceratingTyphoon_01:
                //blade spin in circle, AOE based but not as big of range as other AOE based skills
                break;
        }
        switch (buttonType)
        {
            case type.AscendingShot_01:
                //do a jump back and up, shoot arrows down lane you jump away from
                break;
        }
        switch (buttonType)
        {
            case type.PiercingFist_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.HeavenPiercer_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.WraithsDestruction_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.HowlingScythe_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.VortexDischarge_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.SearingIgnition_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.Permafrost_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.SpiralingTempest_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.PiercingShot_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.UncontrolledSpeed_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.LaceratingTyphoon_02:
                //second tier of this skill
                break;
        }
        switch (buttonType)
        {
            case type.AscendingShot_02:
                //second tier of this skill
                break;
        }
    }
    #endregion

    #region On first touch function for left and right buttons
    void OnFirstTouch()
    {
        switch (buttonType)
        {
            case type.LeftButton:
                //Left movement here
                playerAnimObject.transform.eulerAngles = new Vector2(0, 180);//
                if(playerObj.GetComponent<Rigidbody2D>().velocity.magnitude < 5 && playerObj.GetComponent<AnimationsManager>().onGround)
                {
                    playerObj.GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
                }
                //playerObj.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                isOn = 1;
                break;
            case type.RightButton:
                //right movement here
                playerAnimObject.transform.eulerAngles = new Vector2(0, 0);//
                if (playerObj.GetComponent<Rigidbody2D>().velocity.magnitude < 5 && playerObj.GetComponent<AnimationsManager>().onGround)
                {
                    playerObj.GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
                }
                //playerObj.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

                isOn = 1;
                break;
        }
    }
    #endregion

    #region On second touch function for left and right buttons
    void OnSecondTouch()
    {
        switch (buttonType)
        {
            case type.LeftButton:
                //left movement here
                playerAnimObject.transform.eulerAngles = new Vector2(0, 180);//
                if (playerObj.GetComponent<Rigidbody2D>().velocity.magnitude < 5 && playerObj.GetComponent<AnimationsManager>().onGround)
                {
                    playerObj.GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
                }
                //playerObj.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

                break;
            case type.RightButton:
                //right movement here
                playerAnimObject.transform.eulerAngles = new Vector2(0, 0);//
                if (playerObj.GetComponent<Rigidbody2D>().velocity.magnitude < 5 && playerObj.GetComponent<AnimationsManager>().onGround)
                {
                    playerObj.GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
                }
                //playerObj.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                break;
        }
    }
    #endregion

    #region is touched ended first and second function checks
    void OnFirstTouchEnded()
    {
        isOn = 0;
    }
    void OnSecondTouchEnded()
    {
        isOn = 0;
    }
    #endregion  

}

