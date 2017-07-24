using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private int _currentHealth;
    private int _currentMaxHealth;
    private int _currentAttack;
    private int _currentRage;
    private int _currentSpeed;
    private int _currentArcane;
    private int _currentDefense;

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

    public void AlterHealth(float healthChange)
    {
        CurrentHealth += (int)healthChange;

        if (CurrentHealth <= 0)
            Die();
    }

    void Die()
    {
        //Do Death Stuffs
    }
}
