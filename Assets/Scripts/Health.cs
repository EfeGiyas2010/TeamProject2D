using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private bool dead;

    public GameObject youDied;
    public GameObject erkekPlayer;

    private void Awake()
    {
        currentHealth = startingHealth;
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {

        }
        else
        {
            if (!dead)
            {
                GetComponent<CharacterController>().enabled = false;
                dead = true;
                youDied.SetActive(true);
                Time.timeScale = 0f;
                erkekPlayer.SetActive(false);

            }
        }
    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
}