using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour, ICharacter
{
    private Rigidbody2D rb;
    private Animation anim;

    private float speed = 3.0f;
	public float startHealth = 10; //tempt
	private float health;

	public Slider healthbar;

	public GameObject SmokeParticle;
	public GameObject ItemObject;

	//base character stats
	[SerializeField] private int _baseMaxHealth;
	[SerializeField] private int _baseAttack;
	[SerializeField] private int _baseDefense;

	//current stats
	private int _currentHealth = 10;
	private int _currentMaxHealth = 10;
	private int _currentAttack;
	private int _currentDefense;
    
	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animation>();
		health = startHealth;
		SmokeParticle.SetActive (false);
    }

    void Update()
    {
        Vector3 d = GameObject.FindWithTag("Player").transform.position;
        Vector3 s = this.transform.position;
        Vector3 distance = s - d;

        if (distance.x > 1f)
        {
            if(rb.velocity.magnitude < 5f)
            {
                rb.velocity = new Vector2(-speed, 0);
            }
        }
        else if (distance.x < 1f)
        {
            if (rb.velocity.magnitude < 5f)
            {
                rb.velocity = new Vector2(speed, 0);
            }
        }		 
    }
		
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
	public int CurrentDefense
	{
		get { return _currentDefense; }
		set { _currentDefense = value; }
	}
		
    public void AlterHealth(float healthChange)
    {
        health -= healthChange;
        healthbar.value = (float)((float)health / (float)_baseMaxHealth);

        if (health <= 0)
			StartCoroutine (Death());
    }
		
	IEnumerator Death()
	{
		SmokeParticle.SetActive (true);
		yield return new WaitForSeconds(1);
		DetermineLoot ();
		Destroy(gameObject);

	}

	public void DetermineLoot()
	{
		if (Random.value == 0.20)
		{
			Instantiate (ItemObject, transform.position, Quaternion.identity); 
		}

		if (Random.value == 0.15)
		{
			//Instantiate (ItemObject, transform.position, Quaternion.identity); 
		}

		if (Random.value == 0.10)
		{
			//Instantiate (ItemObject, transform.position, Quaternion.identity); 
		}

		if (Random.value == 0.05)
		{
			//Instantiate (ItemObject, transform.position, Quaternion.identity); 
		}

		if (Random.value == 0.01)
		{
			//Instantiate (ItemObject, transform.position, Quaternion.identity); 
		}
	}
}
