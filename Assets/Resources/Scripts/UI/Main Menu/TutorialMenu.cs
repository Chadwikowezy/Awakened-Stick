using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialMenu : MonoBehaviour
{
    public ScrollRect scrollView;
    public GameObject[] scrollViewContents;

    private int _currentMenuIndex;

    void ActivateCurrentMenu()
    {
        for (int i = 0; i < scrollViewContents.Length; i++)
        {
            if (i == _currentMenuIndex)
            {
                scrollViewContents[i].SetActive(true);
                scrollView.content = scrollViewContents[i].GetComponent<RectTransform>();
                scrollView.content.transform.position = Vector3.zero;
            }    
            else
                scrollViewContents[i].SetActive(false);
        }
    }

    public void IncreaseMenuIndex()
    {
        if (_currentMenuIndex < scrollViewContents.Length - 1)
        {
            _currentMenuIndex++;
            ActivateCurrentMenu();
        }
    }
    public void DecreaseMenuIndex()
    {
        if (_currentMenuIndex > 0)
        {
            _currentMenuIndex--;
            ActivateCurrentMenu();
        }
    }
    public void CloseMenu()
    {
        gameObject.SetActive(false);
    }
}
