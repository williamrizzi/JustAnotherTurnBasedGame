using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSkills : MonoBehaviour
{

    public bool redArcherSkill;
    public bool redMageSkill;
    public bool redLancerSkill;

    public BalanceScript balance;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        balance = GameObject.FindGameObjectWithTag("GameController").GetComponentInChildren<BalanceScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - (speed * Time.deltaTime), transform.position.y, transform.position.z);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Archer")
        {
            if (redArcherSkill == true)
            {
                collision.GetComponent<Archer>().ReceiveDamage(balance.archerDamage);
            }
            if (redMageSkill == true)
            {
                collision.GetComponent<Archer>().ReceiveDamage(balance.mageDamage);
            }
            if (redLancerSkill == true)
            {
                collision.GetComponent<Archer>().ReceiveDamage(balance.tankDamage);
                Destroy(gameObject);
            }
        }
        if (collision.transform.tag == "Mage")
        {
            if (redArcherSkill == true)
            {
                collision.GetComponent<Mage>().ReceiveDamage(balance.archerDamage);
            }
            if (redMageSkill == true)
            {
                collision.GetComponent<Mage>().ReceiveDamage(balance.mageDamage);
            }
            if (redLancerSkill == true)
            {
                collision.GetComponent<Mage>().ReceiveDamage(balance.tankDamage);
                Destroy(gameObject);
            }
        }
        if (collision.transform.tag == "Tank")
        {
            if (redArcherSkill == true)
            {
                collision.GetComponent<Tank>().ReceiveDamage(balance.archerDamage);
            }
            if (redMageSkill == true)
            {
                collision.GetComponent<Tank>().ReceiveDamage(balance.mageDamage);
            }
            if (redLancerSkill == true)
            {
                collision.GetComponent<Tank>().ReceiveDamage(balance.tankDamage);
                Destroy(gameObject);
            }
        }
        if (collision.transform.tag == "EndScreen")
        {
            Destroy(gameObject);
        }
    }
}
