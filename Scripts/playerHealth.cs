using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour
{
    public int health = 0; // an adjustable amount of health that is affected by gameplay.
    public int maxHealth = 100; //the maximum amount of health the player will have.

    private foodPills healthFood;

    private void Awake()
    {
        healthFood = GameObject.Find("food").GetComponent<foodPills>();
    }

    private void Start()
    {
        health = 100;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (health != maxHealth)
        {
            if (other.gameObject.tag.Contains("food"))
            {
                health = health + healthFood.healthPills;
            }
        }
    }
}