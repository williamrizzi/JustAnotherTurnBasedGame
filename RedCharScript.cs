using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCharScript : MonoBehaviour
{

    public EnemyManager enemyManager;

    public GameObject arrow;
    public GameObject fireBall;
    public GameObject spear;

    public bool redArcher;
    public bool redMage;
    public bool redLancer;

    private BalanceScript balance;

    private float maxLife;
    private float maxShield;

    public float life;
    public float shield;
    public float damage;

    public GameObject archerLifeBar;
    public GameObject archerShieldBar;

    public GameObject mageLifeBar;
    public GameObject mageShieldBar;

    public GameObject lancerLifeBar;
    public GameObject lancerShieldBar;


    public Sprite[] lifeBarRef;
    public Sprite[] shieldBarRef;

    // Start is called before the first frame update
    void Start()
    {
        balance = GameObject.FindGameObjectWithTag("GameController").GetComponent<BalanceScript>();

        if(redArcher == true)
        {
            maxLife = balance.archerLife;
            maxShield = balance.archerShield;
            life = balance.archerLife;
            shield = balance.archerShield;
            damage = balance.archerDamage;
        }
        if (redMage == true)
        {
            maxLife = balance.mageLife;
            maxShield = balance.mageShield;
            life = balance.mageLife;
            shield = balance.mageShield;
            damage = balance.mageDamage;
        }
        if (redLancer == true)
        {
            maxLife = balance.tankLife;
            maxShield = balance.tankShield;
            life = balance.tankLife;
            shield = balance.tankShield;
            damage = balance.tankDamage;
        }
    }

    // Update is called once per frame
    void Update()
    {
        LifeBar();
        ShieldBar();
        Death();

        if (life >= maxLife)
        {
            life = maxLife;
        }
        if (shield >= maxShield)
        {
            shield = maxShield;
        }
    }

    public void ReceiveDamage(float r_damage)
    {
        if(shield != 0)
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

    private void LifeBar()
    {
        if (redArcher == true)
        {
            if (life <= 0)
            {
                archerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[0];
            }
            else if (life > 0f && life <= (maxLife / 4f))
            {
                archerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[1];
            }
            else if (life > (maxLife / 4f) && life <= ((maxLife / 4f) * 2f))
            {
                archerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[2];
            }
            else if (life > ((maxLife / 4f) * 2f) && life <= ((maxLife / 4f) * 3f))
            {
                archerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[3];
            }
            else if (life > ((maxLife / 4f) * 3f) && life <= maxLife)
            {
                archerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[4];
            }
        }
        if (redMage == true)
        {
            if (life <= 0)
            {
                mageLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[0];
            }
            else if (life > 0f && life <= (maxLife / 4f))
            {
                mageLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[1];
            }
            else if (life > (maxLife / 4f) && life <= ((maxLife / 4f) * 2f))
            {
                mageLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[2];
            }
            else if (life > ((maxLife / 4f) * 2f) && life <= ((maxLife / 4f) * 3f))
            {
                mageLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[3];
            }
            else if (life > ((maxLife / 4f) * 3f) && life <= maxLife)
            {
                mageLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[4];
            }
        }
        if (redLancer == true)
        {
            if (life <= 0)
            {
                lancerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[0];
            }
            else if (life > 0f && life <= (maxLife / 4f))
            {
                lancerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[1];
            }
            else if (life > (maxLife / 4f) && life <= ((maxLife / 4f) * 2f))
            {
                lancerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[2];
            }
            else if (life > ((maxLife / 4f) * 2f) && life <= ((maxLife / 4f) * 3f))
            {
                lancerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[3];
            }
            else if (life > ((maxLife / 4f) * 3f) && life <= maxLife)
            {
                lancerLifeBar.GetComponent<SpriteRenderer>().sprite = lifeBarRef[4];
            }
        }
    }

    private void ShieldBar()
    {
        if (redArcher == true)
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
        if (redMage == true)
        {
            if (shield <= 0)
            {
                mageShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[0];
            }
            else if (shield > 0f && shield <= (maxShield / 4f))
            {
                mageShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[1];
            }
            else if (shield > (maxShield / 4f) && shield <= ((maxShield / 4f) * 2f))
            {
                mageShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[2];
            }
            else if (shield > ((maxShield / 4f) * 2f) && shield <= ((maxShield / 4f) * 3f))
            {
                mageShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[3];
            }
            else if (shield > ((maxShield / 4f) * 3f) && shield <= maxShield)
            {
                mageShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[4];
            }
        }
        if (redLancer == true)
        {
            if (shield <= 0)
            {
                lancerShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[0];
            }
            else if (shield > 0f && shield <= (maxShield / 4f))
            {
                lancerShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[1];
            }
            else if (shield > (maxShield / 4f) && shield <= ((maxShield / 4f) * 2f))
            {
                lancerShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[2];
            }
            else if (shield > ((maxShield / 4f) * 2f) && shield <= ((maxShield / 4f) * 3f))
            {
                lancerShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[3];
            }
            else if (shield > ((maxShield / 4f) * 3f) && shield <= maxShield)
            {
                lancerShieldBar.GetComponent<SpriteRenderer>().sprite = shieldBarRef[4];
            }
        }
    }

    public void LetsAttack()
    {
        if(redArcher == true)
        {
            if (enemyManager.archerLive == true)
            {
                Instantiate(arrow, transform.position, transform.rotation);
            }
        }
        if(redMage == true)
        {
            if (enemyManager.mageLive == true)
            {
                Instantiate(fireBall, transform.position, transform.rotation);
            }
        }
        if(redLancer == true)
        {
            if (enemyManager.lancerLive == true)
            {
                Instantiate(spear, transform.position, transform.rotation);
            }
        }
    }



    public void Death()
    {
        if(life <= 0)
        {
            if (redArcher == true)
            {
                enemyManager.enemyCount -= 1;
                enemyManager.archerLive = false;
                Destroy(gameObject);
            }
            if (redMage == true)
            {
                enemyManager.enemyCount -= 1;
                enemyManager.mageLive = false;
                Destroy(gameObject);

            }
            if(redLancer == true)
            {
                enemyManager.enemyCount -= 1;
                enemyManager.lancerLive = false;
                Destroy(gameObject);
            }
        }
    }

}
