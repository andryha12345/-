using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Player player; 

    Image healthBar;
    public float maxHealth = 100f;


    void Start()
    {
        healthBar = GetComponent<Image>();
        player.HP = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = player.HP / maxHealth;
    }
}
