using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour, ICharacter
{
    //base character stats
    [SerializeField] private int _baseMaxHealth;
    [SerializeField] private int _baseAttack;
    [SerializeField] private int _baseRage;
    [SerializeField] private int _baseSpeed;
    [SerializeField] private int _baseArcane;
    [SerializeField] private int _baseDefense;

    //current stats
    private int _currentHealth = 50;
    private int _currentMaxHealth = 50;
    private int _currentAttack;
    private int _currentRage;
    private int _currentSpeed;
    private int _currentArcane;
    private int _currentDefense;

    public Slider healthBar;
    public Text currentHealthText;
    public GameObject deathEffect;
    private HandleCanvas handleCanvas;
    public GameObject deathTextOBJ;

    //properties
    public int BaseMaxHealth
    {
        get { return _baseMaxHealth; }
        set { _baseMaxHealth = value; }
    }
    public int BaseAttack
    {
        get { return _baseAttack; }
        set { _baseAttack = value; }
    }
    public int BaseRage
    {
        get { return _baseRage; }
        set { _baseRage = value; }
    }
    public int BaseSpeed
    {
        get { return _baseSpeed; }
        set { _baseSpeed = value; }
    }
    public int BaseArcane
    {
        get { return _baseArcane; }
        set { _baseArcane = value; }
    }
    public int BaseDefense
    {
        get { return _baseDefense; }
        set { _baseDefense = value; }
    }
    public int CurrentHealth
    {
        get { return _currentHealth; }
        set
        {
            _currentHealth = value;
            _currentHealth = Mathf.Clamp(_currentHealth, 0, _currentMaxHealth);
        }
    }
    public int CurrentMaxHealth
    {
        get { return _currentMaxHealth; }
        set
        {
            _currentMaxHealth = value;

            if (_currentHealth > _currentMaxHealth)
                _currentHealth = _currentMaxHealth;
        }
    }
    public int CurrentAttack
    {
        get { return _currentAttack; }
        set { _currentAttack = value; }
    }
    public int CurrentRage
    {
        get { return _currentRage; }
        set { _currentRage = value; }
    }
    public int CurrentSpeed
    {
        get { return _currentSpeed; }
        set { _currentSpeed = value; }
    }
    public int CurrentArcane
    {
        get { return _currentArcane; }
        set { _currentArcane = value; }
    }
    public int CurrentDefense
    {
        get { return _currentDefense; }
        set { _currentDefense = value; }
    }

    void Start()
    {
        currentHealthText.text = CurrentHealth + "/" + CurrentMaxHealth;
    }

    public void AlterHealth(int healthChange)
    {
        CurrentHealth -= (int)healthChange;
        healthBar.value = (float)((float)CurrentHealth / (float)CurrentMaxHealth);
        currentHealthText.text = CurrentHealth + "/" + CurrentMaxHealth;

        if (CurrentHealth <= 0)
            StartCoroutine(Die());
    }
    public void ReturnHealth(int healthChange)
    {
        if(CurrentHealth < CurrentMaxHealth)
        {
            CurrentHealth += (int)healthChange;
            healthBar.value = (float)((float)CurrentHealth / (float)CurrentMaxHealth);
            currentHealthText.text = CurrentHealth + "/" + CurrentMaxHealth;
        }     
    }

    IEnumerator Die()
    {
        //Do Death Stuffs
        handleCanvas = FindObjectOfType<HandleCanvas>();
        handleCanvas.canUseButtons = false;
        deathTextOBJ.SetActive(true);
        deathEffect.SetActive(true);
        ItemReturnManager itemReturnManager = FindObjectOfType<ItemReturnManager>();
        if(itemReturnManager.itemsNotAdded.Count > 0)
        {
            itemReturnManager.ItemsNeedToBeAdded();
        }
        GameController gameController = FindObjectOfType<GameController>();
        for (int i = 0; i < 1; i++)
        {
            gameController.Save();
        }
        yield return new WaitForSeconds(4f);
        Application.LoadLevel("Main Menu");
    }
}
