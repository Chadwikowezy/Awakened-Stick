using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubMenu : MonoBehaviour
{
    public GameObject[] tabs;
    public GameObject[] tabMenus;

    private bool _isActiveMenu;
    private Animator _anim;
    private GameObject _activeTab;

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

            if (_anim == null)
                _anim = GetComponent<Animator>();

            if (previousActiveState == false && newActiveState == true)
                _anim.Play("SubMenu_MoveIn");
            else if (previousActiveState == true && newActiveState == false)
                _anim.Play("SubMenu_MoveOut");

            _isActiveMenu = newActiveState;
        }
    }

    public void TabOne()
    {
        for (int i = 0; i < tabs.Length; i++)
        {
            tabs[i].GetComponent<Image>().color = new Color(0.4f, 0.4f, 0.4f, 1f);
            tabMenus[i].SetActive(false);
        }

        tabs[0].GetComponent<Image>().color = Color.white;
        tabs[0].transform.SetSiblingIndex(transform.parent.childCount);
        tabMenus[0].SetActive(true);
    }
    public void TabTwo()
    {
        for (int i = 0; i < tabs.Length; i++)
        {
            tabs[i].GetComponent<Image>().color = new Color(0.4f, 0.4f, 0.4f, 1f);
            tabMenus[i].SetActive(false);
        }

        tabs[1].GetComponent<Image>().color = Color.white;
        tabs[1].transform.SetSiblingIndex(transform.parent.childCount);
        tabMenus[1].SetActive(true);
    }
    public void TabThree()
    {

    }
}
