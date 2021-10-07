using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyManager : MonoBehaviour
{
    public int allyCount;

    public bool archerLive;
    public bool mageLive;
    public bool lancerLive;

    public GameObject archer;
    public GameObject mage;
    public GameObject lancer;

    public GameObject arrow;
    public GameObject fireBall;
    public GameObject spear;

    public GameObject[] xIcon;

    public BalanceScript balance;

    public bool archerReceiveDmg;
    public bool mageReceiveDmg;
    public bool lancerReceiveDmg;



    // Start is called before the first frame update
    void Start()
    {
        archerLive = true;
        mageLive = true;
        lancerLive = true;
        allyCount = 3;
        archerReceiveDmg = false;
        mageReceiveDmg = false;
        lancerReceiveDmg = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Archer
        if(archerLive == false)
        {
            xIcon[0].SetActive(true);
        }
        else
        {
            xIcon[0].SetActive(false);
        }
        // Mage
        if(mageLive == false)
        {
            xIcon[1].SetActive(true);
        }
        else
        {
            xIcon[1].SetActive(false);
        }
        // Lancer
        if(lancerLive == false)
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

    public void BlueArcherAttack()
    {
        if (archerLive == true)
        {
            Instantiate(arrow, archer.transform.position, archer.transform.rotation);
        }   
    }
    
    public void BlueMageAttack()
    {
        if(mageLive == true)
        {
            Instantiate(fireBall, mage.transform.position, mage.transform.rotation);
        }
    }

    public void BlueLancerAttack()
    {
        if (lancerLive == true)
        {
            Instantiate(spear, lancer.transform.position, lancer.transform.rotation);
        }
            
    }

    public void ActiveBuffs()
    {
        if(archerLive == true)
        {
            print("TESTE: " + archer.transform.position.x);
            int xx = Convert.ToInt32(archer.transform.position.x);

            if (archer.transform.position.x == -4)
            {
                archer.GetComponent<Archer>().life = archer.GetComponent<Archer>().life + balance.modLife;
            }
            else if (archer.transform.position.x == -3)
            {
                archer.GetComponent<Archer>().shield = archer.GetComponent<Archer>().shield + balance.modShield;
            }
            else if (xx == -2) 
            {
                Debug.Log("to aqui");
                archer.GetComponent<Archer>().damage = archer.GetComponent<Archer>().damage + balance.modDamage;
                archerReceiveDmg = true;
            }
        }
        if (mageLive == true)
        {
            if (mage.transform.position.x == -4)
            {
                mage.GetComponent<Mage>().life = mage.GetComponent<Mage>().life + balance.modLife;
            }
            if (mage.transform.position.x == -3)
            {
                mage.GetComponent<Mage>().shield = mage.GetComponent<Mage>().shield + balance.modShield;
            }
            if (mage.transform.position.x == -2)
            {
                mage.GetComponent<Mage>().damage = mage.GetComponent<Mage>().damage + balance.modDamage;
                mageReceiveDmg = true;
            }
        }
        if (lancerLive == true)
        {
            if (lancer.transform.position.x == -4)
            {
                lancer.GetComponent<Tank>().life = lancer.GetComponent<Tank>().life + balance.modLife;
            }
            if (lancer.transform.position.x == -3)
            {
                lancer.GetComponent<Tank>().shield = lancer.GetComponent<Tank>().shield + balance.modShield;
            }
            if (lancer.transform.position.x == -2)
            {
                lancer.GetComponent<Tank>().damage = lancer.GetComponent<Tank>().damage + balance.modDamage;
                lancerReceiveDmg = true;
            }
        }
    }

    public void RemoveBuffs()
    {
        if(archerLive == true)
        {
            if (archerReceiveDmg == true)
            {
                archer.GetComponent<Archer>().damage = archer.GetComponent<Archer>().damage - balance.modDamage;
                archerReceiveDmg = false;
            }
        }
        if(mageLive == true)
        {
            if (mageReceiveDmg == true)
            {
                mage.GetComponent<Mage>().damage = mage.GetComponent<Mage>().damage - balance.modDamage;
                mageReceiveDmg = false;
            }
        }
        if(lancerLive == true)
        {
            if (lancerReceiveDmg == true)
            {
                lancer.GetComponent<Tank>().damage = lancer.GetComponent<Tank>().damage - balance.modDamage;
                lancerReceiveDmg = false;
            }
        }
    }
}
