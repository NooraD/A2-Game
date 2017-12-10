using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour 
{
	public int maxHealth = 100;
	public int currentHealth { get; private set; }

	public Image currentHealthbar;
	public Text ratioText;



	void Awake ()
	{
		currentHealth = maxHealth;
	}

	void Start ()
	{
		UpdateHealthbar ();
	}

	void Update()
	{

	}

	public void TakeDamage (int damage)
	{
		currentHealth -= damage;
		Debug.Log (transform.name + " takes " + damage + " damage.");

		 UpdateHealthbar ();

		if (currentHealth <= 0) 
		{
			currentHealth = 0;
			Die ();
		}
	}

	private void UpdateHealthbar()
	{
		float ratio = (currentHealth / maxHealth);
		currentHealthbar.rectTransform.localScale = new Vector3 (ratio, 1, 1);
		ratioText.text = (ratio * 100).ToString ("0") + '%';
	}

	public virtual void Die()
	{
		//die
		Debug.Log (transform.name + "died.");
	}
}
