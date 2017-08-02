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

    public Sprite piercingFist, heavenPiercer, wrathDestruction, howlingScythe;
    public Sprite vortexDischarge, searingIgnition, permaFrost, spiralingTempest;
    public Sprite piercingShot, uncontrolledSpeed, laceratingTyphoon, ascendingShot;

    public GameObject playerObj = null;
    Rigidbody2D playerRigidBody = null;

    public GUITexture buttonTexture;
    public GUITexture buttonOnCDTexture;

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

    #region button sprite setter
    public void AssignButtonSprite()
    {
        if(buttonType == type.PiercingFist_01)
        {
            GetComponent<GUITexture>().texture = piercingFist.texture;
        }
        else if (buttonType == type.HeavenPiercer_01)
        {
            GetComponent<GUITexture>().texture = heavenPiercer.texture;
        }
        else if (buttonType == type.WraithsDestruction_01)
        {
            GetComponent<GUITexture>().texture = wrathDestruction.texture;
        }
        else if (buttonType == type.HowlingScythe_01)
        {
            GetComponent<GUITexture>().texture = howlingScythe.texture;
        }
        else if (buttonType == type.VortexDischarge_01)
        {
            GetComponent<GUITexture>().texture = vortexDischarge.texture;
        }
        else if (buttonType == type.SearingIgnition_01)
        {
            GetComponent<GUITexture>().texture = searingIgnition.texture;
        }
        else if (buttonType == type.Permafrost_01)
        {
            GetComponent<GUITexture>().texture = permaFrost.texture;
        }
        else if (buttonType == type.SpiralingTempest_01)
        {
            GetComponent<GUITexture>().texture = spiralingTempest.texture;
        }
        else if (buttonType == type.PiercingShot_01)
        {
            GetComponent<GUITexture>().texture = piercingShot.texture;
        }
        else if (buttonType == type.UncontrolledSpeed_01)
        {
            GetComponent<GUITexture>().texture = uncontrolledSpeed.texture;
        }
        else if (buttonType == type.LaceratingTyphoon_01)
        {
            GetComponent<GUITexture>().texture = laceratingTyphoon.texture;
        }
        else if (buttonType == type.AscendingShot_01)
        {
            GetComponent<GUITexture>().texture = ascendingShot.texture;
        }
    }
    #endregion

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
                animManager.Shield();
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
                animManager.WraithsDestruction();
                break;
        }
        switch (buttonType)
        {
            case type.HowlingScythe_01:
                animManager.HowlingScythe();
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
                animManager.Permafrost();
                break;
        }
        switch (buttonType)
        {
            case type.SpiralingTempest_01:
                animManager.SpiralingTempest();
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
                animManager.UncontrolledSpeed();
                break;
        }
        switch (buttonType)
        {
            case type.LaceratingTyphoon_01:
                animManager.LaceratingTyphoon();
                break;
        }
        switch (buttonType)
        {
            case type.AscendingShot_01:
                animManager.AscendingShot();
                break;
        }
        switch (buttonType)
        {
            case type.PiercingFist_02:
                animManager.PiercingFist();
                break;
        }
        switch (buttonType)
        {
            case type.HeavenPiercer_02:
                animManager.HeavenPiercer();
                break;
        }
        switch (buttonType)
        {
            case type.WraithsDestruction_02:
                animManager.WraithsDestruction();
                break;
        }
        switch (buttonType)
        {
            case type.HowlingScythe_02:
                animManager.HowlingScythe();
                break;
        }
        switch (buttonType)
        {
            case type.VortexDischarge_02:
                animManager.VortexDischarge();
                break;
        }
        switch (buttonType)
        {
            case type.SearingIgnition_02:
                animManager.SearingIgnition();
                break;
        }
        switch (buttonType)
        {
            case type.Permafrost_02:
                animManager.Permafrost();
                break;
        }
        switch (buttonType)
        {
            case type.SpiralingTempest_02:
                animManager.SpiralingTempest();
                break;
        }
        switch (buttonType)
        {
            case type.PiercingShot_02:
                animManager.PiercingShot();
                break;
        }
        switch (buttonType)
        {
            case type.UncontrolledSpeed_02:
                animManager.UncontrolledSpeed();
                break;
        }
        switch (buttonType)
        {
            case type.LaceratingTyphoon_02:
                animManager.LaceratingTyphoon();
                break;
        }
        switch (buttonType)
        {
            case type.AscendingShot_02:
                animManager.AscendingShot();
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
                animManager.Shield();
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
                animManager.WraithsDestruction();
                break;
        }
        switch (buttonType)
        {
            case type.HowlingScythe_01:
                animManager.HowlingScythe();
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
                animManager.Permafrost();
                break;
        }
        switch (buttonType)
        {
            case type.SpiralingTempest_01:
                animManager.SpiralingTempest();
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
                animManager.UncontrolledSpeed();
                break;
        }
        switch (buttonType)
        {
            case type.LaceratingTyphoon_01:
                animManager.LaceratingTyphoon();
                break;
        }
        switch (buttonType)
        {
            case type.AscendingShot_01:
                animManager.AscendingShot();
                break;
        }
        switch (buttonType)
        {
            case type.PiercingFist_02:
                animManager.PiercingFist();
                break;
        }
        switch (buttonType)
        {
            case type.HeavenPiercer_02:
                animManager.HeavenPiercer();
                break;
        }
        switch (buttonType)
        {
            case type.WraithsDestruction_02:
                animManager.WraithsDestruction();
                break;
        }
        switch (buttonType)
        {
            case type.HowlingScythe_02:
                animManager.HowlingScythe();
                break;
        }
        switch (buttonType)
        {
            case type.VortexDischarge_02:
                animManager.VortexDischarge();
                break;
        }
        switch (buttonType)
        {
            case type.SearingIgnition_02:
                animManager.SearingIgnition();
                break;
        }
        switch (buttonType)
        {
            case type.Permafrost_02:
                animManager.Permafrost();
                break;
        }
        switch (buttonType)
        {
            case type.SpiralingTempest_02:
                animManager.SpiralingTempest();
                break;
        }
        switch (buttonType)
        {
            case type.PiercingShot_02:
                animManager.PiercingShot();
                break;
        }
        switch (buttonType)
        {
            case type.UncontrolledSpeed_02:
                animManager.UncontrolledSpeed();
                break;
        }
        switch (buttonType)
        {
            case type.LaceratingTyphoon_02:
                animManager.LaceratingTyphoon();
                break;
        }
        switch (buttonType)
        {
            case type.AscendingShot_02:
                animManager.AscendingShot();
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
                if(playerObj.GetComponent<Rigidbody2D>().velocity.magnitude < 5 && playerObj.GetComponent<AnimationsManager>().onGround && playerObj.transform.position.x > -50)
                {
                    playerObj.GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
                }
                //playerObj.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                isOn = 1;
                break;
            case type.RightButton:
                //right movement here
                playerAnimObject.transform.eulerAngles = new Vector2(0, 0);//
                if (playerObj.GetComponent<Rigidbody2D>().velocity.magnitude < 5 && playerObj.GetComponent<AnimationsManager>().onGround && playerObj.transform.position.x < 50)
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

