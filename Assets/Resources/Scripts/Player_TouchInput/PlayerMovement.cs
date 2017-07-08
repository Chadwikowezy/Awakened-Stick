using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : TouchManager
{
    #region variables
    //touchbuttons
    public enum type { LeftButton, RightButton, JumpButton, ShieldButton, Punch_01, Kick_01, EnergyBow_01, Cast_01 };
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
            case type.Punch_01:
                animManager.PunchSkill();
                break;
        }
        switch (buttonType)
        {
            case type.Kick_01:
                animManager.KickSkill();
                break;
        }
        switch (buttonType)
        {
            case type.EnergyBow_01:
                animManager.ArrowSkill();
                break;
        }
        switch (buttonType)
        {
            case type.Cast_01:
                animManager.Cast_01();
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
            case type.Punch_01:
                animManager.PunchSkill();
                break;
        }
        switch (buttonType)
        {
            case type.Kick_01:
                animManager.KickSkill();
                break;
        }
        switch (buttonType)
        {
            case type.EnergyBow_01:
                animManager.ArrowSkill();
                break;
        }
        switch (buttonType)
        {
            case type.Cast_01:
                animManager.Cast_01();
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

