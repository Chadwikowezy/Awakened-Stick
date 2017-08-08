using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour, ICharacter
{
	#region Variables
	private Rigidbody2D rb;
    private Animator anim;
    private Player player;

    private float moveSpeed = 4;

    public Slider healthBar;

    public GameObject smokePrarticle;
    public GameObject itemDropOBJ;
	public GameObject raycastObject;
	public GameObject arrowObj;
	public GameObject ascendingArrow;
	public GameObject vortexDischargeOBJ;
	public GameObject searingIgnitionEffect;
	public GameObject piercingFistOBJ;
	public GameObject scytheObj;
	public GameObject wrathOBJ;
	public GameObject spiralingTempestOBJ;
	public GameObject laceratingTyphoonOBJ;
	public GameObject permaFrostOBJ;
    //base character stats
    [SerializeField]
    private int _baseMaxHealth;
    [SerializeField]
    private int _baseAttack;
    [SerializeField]
    private int _baseDefense;

	private int damageMultiplier;
	private int basedamageMultiplier = 2;
	private int jumpHeight = 15;

	//current stats
    private int _currentHealth = 10;
    private int _currentMaxHealth = 10;
    private int _currentAttack;
    private int _currentDefense;

    private bool inPursuit = true;
    private bool usingSkill = false;
	public bool inMiddleOfSkillCast;
	private bool longCD;

	#endregion

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

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<Player>();
        anim = GetComponentInChildren<Animator>();
        smokePrarticle.SetActive(false);
    }

    void Update()
    {
        if (transform.position.x <= player.transform.position.x && inPursuit == true)
        {
            anim.gameObject.transform.eulerAngles = new Vector2(0, 0);
            if (Vector2.Distance(transform.position, player.transform.position) >= 2f)
            {
                if (rb.velocity.magnitude <= 2f)
                {
                    rb.velocity = new Vector2(moveSpeed, 0);
                    //anim.SetInteger("Idle", 0);
                    anim.SetInteger("run", 1);
                }
            }
            else if(Vector2.Distance(transform.position, player.transform.position) <= 7f)
            {
                inPursuit = false;
                StartCoroutine(abilityRandomizer());
            }

			else if(Vector2.Distance(transform.position, player.transform.position) <= 3f)
			{
				inPursuit = false;
				StartCoroutine(abilityRandomizer2());
			}
        }
        else if (transform.position.x > player.transform.position.x && inPursuit == true)
        {
            anim.gameObject.transform.eulerAngles = new Vector2(0, 180);
            if (Vector2.Distance(transform.position, player.transform.position) >= 2f)
            {
                if (rb.velocity.magnitude <= 2f)
                {
                    rb.velocity = new Vector2(-moveSpeed, 0);
                    //anim.SetInteger("Idle", 0);
                    anim.SetInteger("run", 1);
                }
            }
            else if (Vector2.Distance(transform.position, player.transform.position) <= 7f)
            {
                inPursuit = false;
                StartCoroutine(abilityRandomizer());
            }

			else if (Vector2.Distance(transform.position, player.transform.position) <= 3f)
			{
				inPursuit = false;
				StartCoroutine(abilityRandomizer2());
			}
        }
    }
   
	#region string plugin function for what animation to play
    void animStringCaller(string abilityUsing)
    {
        anim.SetInteger("shield", 0);
        anim.SetInteger("frost", 0);
        anim.SetInteger("scythe", 0);
        anim.SetInteger("tempest", 0);
        anim.SetInteger("uncontrolled", 0);
        anim.SetInteger("wrath", 0);
        anim.SetInteger("jump", 0);
        anim.SetInteger("ascending", 0);
        anim.SetInteger("run", 0);
        anim.SetInteger("idle", 0);
        anim.SetInteger("fist", 0);
        anim.SetInteger("kick", 0);
        anim.SetInteger("vortex", 0);
        anim.SetInteger("ignition", 0);
        anim.SetInteger("arrow", 0);
        anim.SetInteger("lacerate", 0);
        anim.SetInteger(abilityUsing, 1);

    }
    #endregion

    IEnumerator abilityRandomizer()
    {
        Debug.Log("got to coroutine call");

        usingSkill = true;
        inPursuit = false;
        int useAttack = Random.Range(0, 10);
        if(useAttack == 1)
        {
            //animStringCaller("arrow");
			PiercingShot();
        }
        
        else if (useAttack == 2)
        {
			//animStringCaller("ignition");
			SearingIgnition();
        }
        else if (useAttack == 2)
        {
			//animStringCaller("vortex");
			VortexDischarge();
        }
        
        else if (useAttack == 3)
        {
			//animStringCaller("wrath");
			WraithsDestruction();
        }
        else if (useAttack == 4)
        {
			//animStringCaller("uncontrolled");
			UncontrolledSpeed();
        }
        else if (useAttack == 5)
        {
			//animStringCaller("tempest");
			SpiralingTempest();
        }
        else if (useAttack == 6)
        {
			//animStringCaller("scythe");
			HowlingScythe();
        }
        else if (useAttack == 7)
        {
			//animStringCaller("frost");
			Permafrost();
        }
        else if (useAttack == 8)
        {
			//animStringCaller("fist");
			PiercingFist ();
        }
        
        yield return new WaitForSeconds(1.5f);
        animStringCaller("");
        inPursuit = true;
    }

	IEnumerator abilityRandomizer2()
	{
		Debug.Log("got to coroutine call 2");

		usingSkill = true;
		inPursuit = false;
		int useAttack = Random.Range(0, 4);
		if(useAttack == 1)
		{
			//animStringCaller("kick");
			HeavenPiercer();
		}
		else if (useAttack == 2)
		{
			//animStringCaller("ascending");
			AscendingShot();
		}
		else if (useAttack == 3)
		{
			//animStringCaller("lacerate");
			LaceratingTyphoon ();
		}
			
		yield return new WaitForSeconds(1.5f);
		animStringCaller("");
		inPursuit = true;
	}

	#region Piercing Fist 01
	public void PiercingFist()
	{
		if(inMiddleOfSkillCast == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			anim.SetInteger("shield", 0);
			anim.SetInteger("frost", 0);
			anim.SetInteger("lacerate", 0);
			anim.SetInteger("wrath", 0);
			anim.SetInteger("tempest", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("uncontrolled", 0);
			anim.SetInteger("arrow", 0);
			anim.SetInteger("scythe", 0);
			anim.SetInteger("ignition", 0);
			anim.SetInteger("ascending", 0);
			anim.SetInteger("vortex", 0);
			anim.SetInteger("kick", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("fist", 1);

			StartCoroutine(PiercingFistDelay());
		}       
	}
	IEnumerator PiercingFistDelay()
	{
		yield return new WaitForSeconds(.6f);
		GameObject piercingFist = (GameObject)Instantiate(piercingFistOBJ, raycastObject.transform.position, raycastObject.transform.rotation);
		usingSkill = false;
		inMiddleOfSkillCast = false;

	}
	#endregion 

	#region Heaven Piercer 01
	public void HeavenPiercer()
	{
		if (inMiddleOfSkillCast == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			anim.SetInteger("shield", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("wrath", 0);
			anim.SetInteger("tempest", 0);
			anim.SetInteger("lacerate", 0);
			anim.SetInteger("frost", 0);
			anim.SetInteger("uncontrolled", 0);
			anim.SetInteger("arrow", 0);
			anim.SetInteger("scythe", 0);
			anim.SetInteger("ignition", 0);
			anim.SetInteger("ascending", 0);
			anim.SetInteger("vortex", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("fist", 0);
			anim.SetInteger("kick", 1);

			StartCoroutine(HeavenPiercerDelay());
		}

	}
	IEnumerator HeavenPiercerDelay()
	{
		yield return new WaitForSeconds(.5f);
		Debug.Log("Before raycast");
		RaycastHit2D hit = Physics2D.Raycast(raycastObject.transform.position, raycastObject.transform.right);
		if (Physics2D.Raycast(raycastObject.transform.position, raycastObject.transform.right, 2f))
		{
			if (hit.collider.tag == "Player")
			{
				//deal damage

				//deal knockback
				damageMultiplier = (player.CurrentRage + 5);

				hit.collider.gameObject.GetComponent<Enemy>().AlterHealth(damageMultiplier);
				if (hit.collider.gameObject.transform.position.x < transform.position.x)
				{
					hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * 500);
					hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250);

				}
				else if (hit.collider.gameObject.transform.position.x > transform.position.x)
				{
					hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 500);
					hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250);
				}

			}
		}
		yield return new WaitForSeconds(.3f);
		usingSkill = false;
		Debug.Log("after raycast");
		inMiddleOfSkillCast = false;
	}
	#endregion

	#region Wraith's Destruction 01
	public void WraithsDestruction()
	{
		if (inMiddleOfSkillCast == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			anim.SetInteger("shield", 0);
			anim.SetInteger("tempest", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("lacerate", 0);
			anim.SetInteger("arrow", 0);
			anim.SetInteger("uncontrolled", 0);
			anim.SetInteger("scythe", 0);
			anim.SetInteger("ascending", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("fist", 0);
			anim.SetInteger("kick", 0);
			anim.SetInteger("vortex", 0);
			anim.SetInteger("ignition", 0);
			anim.SetInteger("frost", 0);
			anim.SetInteger("wrath", 1);

			StartCoroutine(WrathsDestructionDelay());
		}
	}
	IEnumerator WrathsDestructionDelay()
	{
		yield return new WaitForSeconds(.8f);
		damageMultiplier = (player.CurrentRage + basedamageMultiplier);
		wrathOBJ.SetActive(true);
		wrathOBJ.GetComponent<ParticleSystem>().Play();

		Player[] players = FindObjectsOfType<Player>();
		foreach (Player player in players)
		{
			if (player != null)
			{
				player.AlterHealth(damageMultiplier);
			}
		}
		yield return new WaitForSeconds(.4f);

		usingSkill = false;
		inMiddleOfSkillCast = false;
		wrathOBJ.SetActive(false);
	}
	#endregion

	#region Howling Scythe 01
	public void HowlingScythe()
	{
		if (inMiddleOfSkillCast == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			anim.SetInteger("shield", 0);
			anim.SetInteger("frost", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("tempest", 0);
			anim.SetInteger("lacerate", 0);
			anim.SetInteger("wrath", 0);
			anim.SetInteger("uncontrolled", 0);
			anim.SetInteger("arrow", 0);
			anim.SetInteger("ignition", 0);
			anim.SetInteger("ascending", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("fist", 0);
			anim.SetInteger("kick", 0);
			anim.SetInteger("vortex", 0);
			anim.SetInteger("scythe", 1);

			StartCoroutine(HowlingScytheDelay());
		}
	}
	IEnumerator HowlingScytheDelay()
	{
		yield return new WaitForSeconds(.8f);
		GameObject howlingScythe = (GameObject)Instantiate(scytheObj, raycastObject.transform.position, raycastObject.transform.rotation);

		yield return new WaitForSeconds(.3f);
		usingSkill = false;
		inMiddleOfSkillCast = false;
	}
	#endregion 

	#region Vortex Discharge 01
	public void VortexDischarge()
	{
		if (inMiddleOfSkillCast == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			anim.SetInteger("shield", 0);
			anim.SetInteger("frost", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("lacerate", 0);
			anim.SetInteger("tempest", 0);
			anim.SetInteger("wrath", 0);
			anim.SetInteger("arrow", 0);
			anim.SetInteger("scythe", 0);
			anim.SetInteger("uncontrolled", 0);
			anim.SetInteger("ignition", 0);
			anim.SetInteger("ascending", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("fist", 0);
			anim.SetInteger("kick", 0);
			anim.SetInteger("vortex", 1);

			StartCoroutine(VortexDischargeDelay());
		}
	}
	IEnumerator VortexDischargeDelay()
	{
		yield return new WaitForSeconds(.6f);
		GameObject spell = (GameObject)Instantiate(vortexDischargeOBJ, raycastObject.transform.position, raycastObject.transform.rotation);
		usingSkill = false;
		inMiddleOfSkillCast = false;
	}
	#endregion 

	#region Searing Ignition 01
	public void SearingIgnition()
	{
		if (inMiddleOfSkillCast == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			anim.SetInteger("shield", 0);
			anim.SetInteger("frost", 0);
			anim.SetInteger("tempest", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("lacerate", 0);
			anim.SetInteger("scythe", 0);
			anim.SetInteger("wrath", 0);
			anim.SetInteger("uncontrolled", 0);
			anim.SetInteger("arrow", 0);
			anim.SetInteger("ascending", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("fist", 0);
			anim.SetInteger("kick", 0);
			anim.SetInteger("vortex", 0);
			anim.SetInteger("ignition", 1);

			StartCoroutine(SearingIgnitionDelay());
		}
	}
	IEnumerator SearingIgnitionDelay()
	{
		yield return new WaitForSeconds(2f);
		usingSkill = false;
		inMiddleOfSkillCast = false;
	}
	#endregion 

	#region Permafrost 01
	public void Permafrost()
	{
		if (inMiddleOfSkillCast == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			anim.SetInteger("shield", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("arrow", 0);
			anim.SetInteger("lacerate", 0);
			anim.SetInteger("tempest", 0);
			anim.SetInteger("uncontrolled", 0);
			anim.SetInteger("scythe", 0);
			anim.SetInteger("ascending", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("wrath", 0);
			anim.SetInteger("fist", 0);
			anim.SetInteger("kick", 0);
			anim.SetInteger("vortex", 0);
			anim.SetInteger("ignition", 0);
			anim.SetInteger("frost", 1);

			StartCoroutine(PermafrostDelay());
		}
	}
	IEnumerator PermafrostDelay()
	{
		damageMultiplier = (player.CurrentArcane + basedamageMultiplier);
		permaFrostOBJ.SetActive(true);
		for (int i = 0; i < 5; i++)
		{
			yield return new WaitForSeconds(1f);
			Player[] players = FindObjectsOfType<Player>();
			foreach (Player player in players)
			{
				if (player != null)
				{
					player.AlterHealth(damageMultiplier);
				}
			}
		}
		usingSkill = false;
		inMiddleOfSkillCast = false;
		permaFrostOBJ.SetActive(false);

	}

	#endregion

	#region Spiraling Tempest 01
	public void SpiralingTempest()
	{
		if (inMiddleOfSkillCast == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			anim.SetInteger("shield", 0);
			anim.SetInteger("frost", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("scythe", 0);
			anim.SetInteger("wrath", 0);
			anim.SetInteger("lacerate", 0);
			anim.SetInteger("uncontrolled", 0);
			anim.SetInteger("arrow", 0);
			anim.SetInteger("ascending", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("fist", 0);
			anim.SetInteger("kick", 0);
			anim.SetInteger("vortex", 0);
			anim.SetInteger("ignition", 0);
			anim.SetInteger("tempest", 1);

			StartCoroutine(SpiralingTempestDelay());
		}
	}
	IEnumerator SpiralingTempestDelay()
	{
		spiralingTempestOBJ.SetActive(true);
		gameObject.tag = "Untagged";

		yield return new WaitForSeconds(3f);
		gameObject.tag = "Enemy";
		usingSkill = false;
		inMiddleOfSkillCast = false;
		spiralingTempestOBJ.SetActive(false);
	}
	#endregion 

	#region Piercing Shot 01
	public void PiercingShot()
	{
		if (inMiddleOfSkillCast == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			anim.SetInteger("shield", 0);
			anim.SetInteger("frost", 0);
			anim.SetInteger("scythe", 0);
			anim.SetInteger("tempest", 0);
			anim.SetInteger("lacerate", 0);
			anim.SetInteger("uncontrolled", 0);
			anim.SetInteger("wrath", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("ascending", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("fist", 0);
			anim.SetInteger("kick", 0);
			anim.SetInteger("vortex", 0);
			anim.SetInteger("ignition", 0);
			anim.SetInteger("arrow", 1);


			StartCoroutine(PiercingShotDelay());
		}
	}
	IEnumerator PiercingShotDelay()
	{
		yield return new WaitForSeconds(.6f);
		GameObject arrow = (GameObject)Instantiate(arrowObj, raycastObject.transform.position, raycastObject.transform.rotation);
		usingSkill = false;
		inMiddleOfSkillCast = false;
	}
	#endregion 

	#region Uncontrolled Speed 01
	public void UncontrolledSpeed()
	{
		if (inMiddleOfSkillCast == false && longCD == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			longCD = true;
			anim.SetInteger("shield", 0);
			anim.SetInteger("frost", 0);
			anim.SetInteger("lacerate", 0);
			anim.SetInteger("scythe", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("tempest", 0);
			anim.SetInteger("wrath", 0);
			anim.SetInteger("ascending", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("fist", 0);
			anim.SetInteger("kick", 0);
			anim.SetInteger("vortex", 0);
			anim.SetInteger("ignition", 0);
			anim.SetInteger("arrow", 0);
			anim.SetInteger("uncontrolled", 1);


			StartCoroutine(UncontrolledSpeedDelay());
		}
	} 
	IEnumerator UncontrolledSpeedDelay()
	{
		yield return new WaitForSeconds(.2f);
		if (anim.gameObject.transform.eulerAngles.y == 180 && gameObject.transform.position.x > -40)
		{
			gameObject.transform.position = new Vector3((gameObject.transform.position.x - 10), gameObject.transform.position.y, gameObject.transform.position.z);
		}
		else if (anim.gameObject.transform.eulerAngles.y == 0 && gameObject.transform.position.x < 40)
		{
			gameObject.transform.position = new Vector3((gameObject.transform.position.x + 10), gameObject.transform.position.y, gameObject.transform.position.z);
		}
		usingSkill = false;
		inMiddleOfSkillCast = false;

		yield return new WaitForSeconds(2f);

		longCD = false;
	}
	#endregion 

	#region Lacerating Typhoon 01
	public void LaceratingTyphoon()
	{
		if (inMiddleOfSkillCast == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			anim.SetInteger("shield", 0);
			anim.SetInteger("frost", 0);
			anim.SetInteger("scythe", 0);
			anim.SetInteger("tempest", 0);
			anim.SetInteger("uncontrolled", 0);
			anim.SetInteger("wrath", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("ascending", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("fist", 0);
			anim.SetInteger("kick", 0);
			anim.SetInteger("vortex", 0);
			anim.SetInteger("ignition", 0);
			anim.SetInteger("arrow", 0);
			anim.SetInteger("lacerate", 1);


			StartCoroutine(LaceratingTyphoonDelay());
		}
	}
	IEnumerator LaceratingTyphoonDelay()
	{
		yield return new WaitForSeconds(.6f);
		laceratingTyphoonOBJ.SetActive(true);
		for(int i = 0; i < 3; i++)
		{
			yield return new WaitForSeconds(.4f);
			Player[] players = FindObjectsOfType<Player>();
			damageMultiplier = player.CurrentSpeed;
			foreach (Player player in players)
			{
				if (Vector2.Distance(transform.position, player.transform.position) <= 4)
				{
					player.AlterHealth(damageMultiplier + basedamageMultiplier);
				}
			}
		}

		yield return new WaitForSeconds(.3f);
		laceratingTyphoonOBJ.SetActive(false);
		usingSkill = false;
		inMiddleOfSkillCast = false;
	}
	#endregion

	#region Ascending Shot 01
	public void AscendingShot()
	{
		if (inMiddleOfSkillCast == false && longCD == false)
		{
			usingSkill = true;
			inMiddleOfSkillCast = true;
			longCD = true;
			anim.SetInteger("shield", 0); 
			anim.SetInteger("frost", 0);
			anim.SetInteger("scythe", 0);
			anim.SetInteger("tempest", 0);
			anim.SetInteger("lacerate", 0);
			anim.SetInteger("wrath", 0);
			anim.SetInteger("jump", 0);
			anim.SetInteger("run", 0);
			anim.SetInteger("idle", 0);
			anim.SetInteger("uncontrolled", 0);
			anim.SetInteger("fist", 0);
			anim.SetInteger("kick", 0);
			anim.SetInteger("vortex", 0);
			anim.SetInteger("ignition", 0);
			anim.SetInteger("arrow", 0);
			anim.SetInteger("ascending", 1);

			StartCoroutine(AscendingShotDelay());
		}
	}
	IEnumerator AscendingShotDelay()
	{
		player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
		if (anim.gameObject.transform.eulerAngles.y == 180)
		{
			gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * jumpHeight, ForceMode2D.Impulse);
		}
		else if (anim.gameObject.transform.eulerAngles.y == 0)
		{
			gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * jumpHeight, ForceMode2D.Impulse);
		}

		yield return new WaitForSeconds(1f);
		GameObject arrow = (GameObject)Instantiate(ascendingArrow, raycastObject.transform.position, raycastObject.transform.rotation);
		yield return new WaitForSeconds(.2f);

		usingSkill = false;
		inMiddleOfSkillCast = false;

		yield return new WaitForSeconds(2f);
		longCD = false;

	}
	#endregion
    
	public void AlterHealth(float healthChange)
    {
        _currentHealth -= (int)healthChange;
        healthBar.value = (float)((float)_currentHealth / (float)_baseMaxHealth);

        if (_currentHealth <= 0)
            StartCoroutine(Death());
    }

    IEnumerator Death()
    {
        smokePrarticle.SetActive(true);
        yield return new WaitForSeconds(1);
        DetermineLoot();
        Destroy(gameObject);

    }

    public void DetermineLoot()
    {
        if (Random.value == 0.20)
        {
            Instantiate(itemDropOBJ, transform.position, Quaternion.identity);
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
