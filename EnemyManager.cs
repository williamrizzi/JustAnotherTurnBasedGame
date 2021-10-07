using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int enemyCount;

    public bool archerLive;
    public bool mageLive;
    public bool lancerLive;

    public GameObject archer;
    public GameObject mage;
    public GameObject lancer;

    public GameObject[] xIcon;

    public bool archerReceiveDmg;
    public bool mageReceiveDmg;
    public bool lancerReceiveDmg;

    public BalanceScript balance;

    // Start is called before the first frame update
    void Start()
    {
        archerLive = true;
        mageLive = true;
        lancerLive = true;

        enemyCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        // Archer
        if (archerLive == false)
        {
            xIcon[0].SetActive(true);
        }
        else
        {
            xIcon[0].SetActive(false);
        }
        // Mage
        if (mageLive == false)
        {
            xIcon[1].SetActive(true);
        }
        else
        {
            xIcon[1].SetActive(false);
        }
        // Lancer
        if (lancerLive == false)
        {
            xIcon[2].SetActive(true);
        }
        else
        {
            xIcon[2].SetActive(false);
        }
    }

    public void StartAuras()
    {
        if (archerLive == true)
        {
            archer.GetComponentInChildren<Animator>().SetBool("Attack", true);
        }
        if (mageLive == true)
        {
            mage.GetComponentInChildren<Animator>().SetBool("Attack", true);
        }
        if (lancerLive == true)
        {
            lancer.GetComponentInChildren<Animator>().SetBool("Attack", true);
        }

    }

    public void StopAuras()
    {
        if (archerLive == true)
        {
            archer.GetComponentInChildren<Animator>().SetBool("Attack", false);
        }
        if (mageLive == true)
        {
            mage.GetComponentInChildren<Animator>().SetBool("Attack", false);
        }
        if (lancerLive == true)
        {
            lancer.GetComponentInChildren<Animator>().SetBool("Attack", false);
        }

    }

    public void ActiveBuffs()
    {
        if (archerLive == true)
        {
            if (archer.transform.position.x == 4)
            {
                archer.GetComponent<RedCharScript>().life = archer.GetComponent<RedCharScript>().life + balance.modLife;
            }
            if (archer.transform.position.x == 3)
            {
                archer.GetComponent<RedCharScript>().shield = archer.GetComponent<RedCharScript>().shield + balance.modShield;
            }
            if (archer.transform.position.x == 2)
            {
                Debug.Log("to aqui");
                archer.GetComponent<RedCharScript>().damage = archer.GetComponent<RedCharScript>().damage + balance.modDamage;
                archerReceiveDmg = true;
            }
        }
        if (mageLive == true)
        {
            if (mage.transform.position.x == 4)
            {
                mage.GetComponent<RedCharScript>().life = mage.GetComponent<RedCharScript>().life + balance.modLife;
            }
            if (mage.transform.position.x == 3)
            {
                mage.GetComponent<RedCharScript>().shield = mage.GetComponent<RedCharScript>().shield + balance.modShield;
            }
            if (mage.transform.position.x == 2)
            {
                mage.GetComponent<RedCharScript>().damage = mage.GetComponent<RedCharScript>().damage + balance.modDamage;
                mageReceiveDmg = true;
            }
        }
        if (lancerLive == true)
        {
            if (lancer.transform.position.x == 4)
            {
                lancer.GetComponent<RedCharScript>().life = lancer.GetComponent<RedCharScript>().life + balance.modLife;
            }
            if (lancer.transform.position.x == 3)
            {
                lancer.GetComponent<RedCharScript>().shield = lancer.GetComponent<RedCharScript>().shield + balance.modShield;
            }
            if (lancer.transform.position.x == 2)
            {
                lancer.GetComponent<RedCharScript>().damage = lancer.GetComponent<RedCharScript>().damage + balance.modDamage;
                lancerReceiveDmg = true;
            }
        }
    }

    public void RemoveBuffs()
    {
        if (archerLive == true)
        {
            if (archerReceiveDmg == true)
            {
                archer.GetComponent<RedCharScript>().damage = archer.GetComponent<RedCharScript>().damage - balance.modDamage;
                archerReceiveDmg = false;
            }
        }
        if (mageLive == true)
        {
            if (mageReceiveDmg == true)
            {
                mage.GetComponent<RedCharScript>().damage = mage.GetComponent<RedCharScript>().damage - balance.modDamage;
                mageReceiveDmg = false;
            }
        }
        if (lancerLive == true)
        {
            if (lancerReceiveDmg == true)
            {
                lancer.GetComponent<RedCharScript>().damage = lancer.GetComponent<RedCharScript>().damage - balance.modDamage;
                lancerReceiveDmg = false;
            }
        }
    }


}
