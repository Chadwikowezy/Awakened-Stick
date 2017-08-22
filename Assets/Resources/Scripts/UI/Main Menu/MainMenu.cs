using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Buttons")]
    public GameObject playButton;
    public GameObject equipmentButton;
    public GameObject abilitiesButton;
    public GameObject adButton;
    public GameObject wimpButton;
    public GameObject characterButton;
    public GameObject[] allMainMenuButtons;

    [Space(10), Header("Menus")]
    public GameObject characterMenu;
    public GameObject equipmentMenu;
    public GameObject abilitiesMenu;
    public GameObject tutorialMenu;
    public GameObject[] allSubMenus;

    private GameObject _currentSelectable;
    private GameObject _currentSubMenu;

    private EventSystem _currentSystem;

    public Text waveRecordTextObj;
    public Text playerBioCurrentText;
    public Text playerBioText;

    private void Start()
    {
        InitializeMenus();
    }
    private void Update()
    {
        if (_currentSystem.currentSelectedGameObject == null)
            _currentSystem.SetSelectedGameObject(_currentSelectable);
        else
            _currentSelectable = _currentSystem.currentSelectedGameObject;
    }

    void InitializeMenus()
    {
        Time.timeScale = 1;
        _currentSystem = FindObjectOfType<EventSystem>();
        CharacterButton();
        //playerBioCurrentText.text = PlayerPrefs.GetString("Player Bio");      
    }

    public void SetActiveSelectable(GameObject _selectable)
    {
        _currentSystem.SetSelectedGameObject(_selectable);
    }
    public void SetActiveSubMenu(GameObject _newSubMenu)
    {
        _currentSubMenu = _newSubMenu;
        _currentSubMenu.GetComponent<SubMenu>().IsActiveMenu = true;

        for (int i = 0; i < allSubMenus.Length; i++)
            if (allSubMenus[i] != _currentSubMenu)
                allSubMenus[i].GetComponent<SubMenu>().IsActiveMenu = false;
    }

    //Button Functions
    public void PlayButton()
    {
        SetActiveSelectable(playButton);
        StartCoroutine(LoadPrimaryScene(0.3f));
    }
    public void EquipmentButton()
    {
        SetActiveSelectable(equipmentButton);
        SetActiveSubMenu(equipmentMenu);
    }
    public void AbilitiesButton()
    {
        SetActiveSelectable(abilitiesButton);
        SetActiveSubMenu(abilitiesMenu);
    }
    public void AdButton()
    {
        SetActiveSelectable(adButton);
    }
    public void WimpButton()
    {
        SetActiveSelectable(wimpButton);
        Application.Quit();
    }
    public void CharacterButton()
    {
        SetActiveSelectable(characterButton);
        SetActiveSubMenu(characterMenu);      
    }
    public void WaveTextUpdate()
    {
        Actor actor = FindObjectOfType<Actor>();
        waveRecordTextObj.text = actor.data.waveRecord.ToString();
    }
    public void OpenTutorialMenu()
    {
        tutorialMenu.SetActive(true);
    }
    public void SavePlayerBio()
    {
        //Actor actor = FindObjectOfType<Actor>();
        //actor.data.playerBIO = playerBioText.text;
        //PlayerPrefs.SetString("Player Bio", playerBioText.text);
        //print("saving");
    }

    IEnumerator LoadPrimaryScene(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene("Primary");
    }
}
