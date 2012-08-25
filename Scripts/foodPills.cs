using UnityEngine;

public class foodPills : MonoBehaviour
{
    public int energyPills = 20;
    public int healthPills = 20;

    private playerHealth pHealth;

    private void Awake()
    {
        pHealth = GameObject.Find("Player").GetComponent<playerHealth>();
    }

    private void Update()
    {
        playerHealthCheck();
    }

    private void playerHealthCheck()
    {
        if (pHealth.health == pHealth.maxHealth)
        {
            energyPills = energyPills + healthPills;
        }
        else
        {
            energyPills += energyPills;
        }
    }
}