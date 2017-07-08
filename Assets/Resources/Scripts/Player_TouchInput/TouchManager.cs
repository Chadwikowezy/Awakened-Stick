using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    public static bool guiTouch = false;

    public bool touchLocationDifferent;

    #region TouchInput function, passes in a GUITexture to handle touch management
    public void TouchInput(GUITexture texture)
    {
        if(Input.touchCount > 0)
        {
            if (texture.HitTest(Input.GetTouch(0).position))
            {
                switch (Input.GetTouch(0).phase)
                {
                    case TouchPhase.Began:
                        //swipe here
                        //logic needed

                        //touch
                        SendMessage("OnFirstTouchBegan", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;

                    case TouchPhase.Stationary:
                        //swipe here
                        if(Input.GetTouch(0).position != Input.GetTouch(0).deltaPosition)
                        {
                            touchLocationDifferent = true; 
                        }
                        //logic needed

                        //touch
                        SendMessage("OnFirstTouchStayed", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;

                    case TouchPhase.Moved:
                        SendMessage("OnFirstTouchMoved", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;

                    case TouchPhase.Ended:
                        SendMessage("OnFirstTouchEnded", SendMessageOptions.DontRequireReceiver);
                        guiTouch = false;
                        break;
                }
            }
        }

        if(Input.touchCount > 1)
        {
            if(texture.HitTest(Input.GetTouch(1).position))
            {
                switch (Input.GetTouch(1).phase)
                {
                    case TouchPhase.Began:
                        SendMessage("OnSecondTouchBegan", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnSecondTouch", SendMessageOptions.DontRequireReceiver);
                        break;
                    case TouchPhase.Stationary:
                        SendMessage("OnSecondTouchStayed", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnSecondTouch", SendMessageOptions.DontRequireReceiver);
                        break;
                    case TouchPhase.Moved:
                        SendMessage("OnSecondTouchMoved", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnSecondTouch", SendMessageOptions.DontRequireReceiver);
                        break;
                    case TouchPhase.Ended:
                        SendMessage("OnSecondTouchEnded", SendMessageOptions.DontRequireReceiver);
                        break;

                }
            }
        }
    }
    #endregion
}
