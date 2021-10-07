﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    public AllyManager allyManager;

    public enum PositionY
    {
        L1, L2, L3
    }

    public PositionY statusPosY;     

    private BalanceScript balance;

    private float maxLife;
    private float maxShield;

    public float life;
    public float shield;
    public float damage;

    public GameObject archerLifeBar;
    public GameObject archerShieldBar;
    public Sprite[] lifeBarRef;
    public Sprite[] shieldBarRef;

    // Start is called before the first frame update
    void Start()
    {
        balance = GameObject.FindGameObjectWithTag("GameController").GetComponent<BalanceScript>();

        maxLife = balance.archerLife;
        maxShield = balance.archerShield;
        life = balance.archerLife;
        shield = balance.archerShield;
        damage = balance.archerDamage;
    }

    // Update is called once per frame
    void Update()
    {
        SetLayer();
        LifeBar();
        ShieldBar();
        Death();

        if(life >= maxLife)
        {
            life = maxLife;
        }
        if(shield >= maxShield)
        {
            shield = maxShield;
        }
    }
   
    private void SetLayer()
    {
        if(transform.position.y == -1)
        {
            gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 6;
        }
        if (transform.position.y == -2)
        {
            gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 7;
        }
        if (transform.position.y == -3)
        {
            gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 8;
        }
    }

    private void LifeBar()
    {
        if(life <= 0)
        {
            archerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[0];
        }
        else if(life > 0f && life <= (maxLife / 4f))
        {
            archerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[1];
        }
        else if(life > (maxLife / 4f) && life <= ((maxLife / 4f) * 2f))
        {
            archerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[2];
        }
        else if(life > ((maxLife / 4f) * 2f) && life <= ((maxLife / 4f) * 3f))
        {
            archerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[3];
        }
        else if(life > ((maxLife / 4f) * 3f) && life <= maxLife)
        {
            archerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[4];
        }
    }

    private void ShieldBar()
    {
        if (shield <= 0)
        {
            archerShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[0];
        }
        else if (shield > 0f && shield <= (maxShield / 4f))
        {
            archerShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[1];
        }
        else if (shield > (maxShield / 4f) && shield <= ((maxShield / 4f) * 2f))
        {
            archerShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[2];
        }
        else if (shield > ((maxShield / 4f) * 2f) && shield <= ((maxShield / 4f) * 3f))
        {
            archerShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[3];
        }
        else if (shield > ((maxShield / 4f) * 3f) && shield <= maxShield)
        {
            archerShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[4];
        }
    }

    public void ReceiveDamage(float r_damage)
    {
        if (shield != 0)
        {
            if (r_damage <= shield)
            {
                shield = shield - r_damage;
            }
            else if (r_damage > shield)
            {
                float temp_Damage = r_damage;
                temp_Damage = temp_Damage - shield;
                shield = 0;
                life = life - temp_Damage;
                // finalizar na hora com um return?
                //return;
            }
        }
        else
        {
            life = life - r_damage;
        }
    }

    public void Death()
    {
        if(life <= 0)
        {
            allyManager.allyCount -= 1;
            allyManager.archerLive = false;
            Destroy(gameObject);
        }
    }


}
