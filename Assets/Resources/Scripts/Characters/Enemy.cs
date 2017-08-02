using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour, ICharacter
{
	#region Variables
	private Rigidbody2D rb;
    private Animator anim;
	public Transform player;

    private float speed = 3;
	public float startHealth = 10;
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
	#endregion

	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		anim = GetComponentInChildren<Animator>();
		health = startHealth;
		SmokeParticle.SetActive (false);
		player = FindObjectOfType<Player>().gameObject.transform;
    }
		
	void FixedUpdate()
	{
		//STEVEN'S PILE OF SHIT

		//gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.position, Time.deltaTime * speed); 
		//Vector2 dir = (player.position - transform.position).normalized;
		//rb.AddForce(Vector3.MoveTowards(gameObject.transform.position, player.position,Time.deltaTime * speed));
		//rb.MovePosition((Vector2)transform.position + dir * speed * Time.fixedDeltaTime); 
		//the working solution
		anim.SetInteger ("run", 1);
	}

	/*IEnumerator Move()
	{
		while (Vector2.Distance (transform.position, player.position) > 2.0f)
		{
			transform.position += Vector3.MoveTowards (transform.position, player.position, Time.deltaTime); //* 0.02f
			anim.SetInteger ("run", 1);
		}

			yield return break;
	}*/
		
	#region Properties
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
	#endregion
		
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
