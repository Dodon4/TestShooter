using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    float currentHealth;
    public GameObject LoseMenu;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            if(gameObject.tag.Equals("Player"))
            {
                LoseMenu.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Camera.main.transform.DetachChildren();
                Camera.main.transform.parent = null;
            }
            Destroy(gameObject);
        }
    }
}
