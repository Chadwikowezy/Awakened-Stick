using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMenu : MonoBehaviour
{
    private bool _isActiveMenu;
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public bool IsActiveMenu
    {
        get { return _isActiveMenu; }
        set
        {
            bool previousActiveState = _isActiveMenu;
            bool newActiveState = value;

            if (previousActiveState == false && newActiveState == true)
                _anim.Play("SubMenu_MoveIn");
            else if (previousActiveState == true && newActiveState == false)
                _anim.Play("SubMenu_MoveOut");

            _isActiveMenu = newActiveState;
        }
    }
}
