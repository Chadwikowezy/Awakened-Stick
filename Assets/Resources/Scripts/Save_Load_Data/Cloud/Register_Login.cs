using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using GameSparks.Api.Requests;
using GameSparks.Core;
using System.Collections.Generic;

public class Register_Login : MonoBehaviour
{
    //registration variables
    public Text registerDisplayNameInput;
    public Text registerUsernameInput;
    public Text registerpasswordInput;

    //login Variables
    public Text loginUsername;
    public Text loginPassword;
    private string userId;

    public GameObject loginErrorDisplay;



    void Start()
    {
        loginErrorDisplay.SetActive(false);
    }

    public void RegisterPlayerButton()
    {
        Debug.Log("Register Player...");
        new GameSparks.Api.Requests.RegistrationRequest()
            .SetDisplayName(registerDisplayNameInput.text)
            .SetUserName(registerUsernameInput.text)
            .SetPassword(registerpasswordInput.text)
            .Send((response) =>
            {
                if (!response.HasErrors)
                {
                    Debug.Log("Player Registered displayName:" + response.DisplayName);
                    Debug.Log("Player Registered username: " + response.UserId);
                }
                else
                {
                    Debug.Log("Error Registering Player..." + response.Errors.JSON.ToString());
                }
            });
    }

    public void AuthorizePlayerButton()
    {
        Debug.Log("Authoring Player...");
        new GameSparks.Api.Requests.AuthenticationRequest()
            .SetUserName(loginUsername.text)
            .SetPassword(loginPassword.text)
            .Send((response) =>
            {
                if (!response.HasErrors)
                {
                    Debug.Log("Player Authenticated... \n username: " + response.DisplayName);
                    new AccountDetailsRequest().Send((accDetailsResponse) =>
                    {
                        if (accDetailsResponse.HasErrors)
                        {
                            //failed
                        }
                        else
                        {
                            
                        }
                    });
                    Application.LoadLevel("Json_GameSparks");
                }
                else
                {
                    userId = response.UserId;
                    StartCoroutine(loginFailureMessageDisplay());
                    Debug.Log("Error Authenticating Player... \n" + response.Errors.JSON.ToString());
                }
            });
    }

    

    public void AuthenticationDeviceButton()
    {
        Debug.Log("Authenticating Device...");
        new GameSparks.Api.Requests.DeviceAuthenticationRequest()
            .SetDisplayName("Name")
            .Send((response) =>
            {
                if (!response.HasErrors)
                {
                    Debug.Log("Device Authenticated...");
                }
                else
                {
                    Debug.Log("Error Authenticating Device...");
                }
            });
    }


    IEnumerator loginFailureMessageDisplay()
    {
        loginErrorDisplay.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        loginErrorDisplay.SetActive(false);
    }




}
