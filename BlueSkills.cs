using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSkills : MonoBehaviour
{
    public bool blueArcherSkill;
    public bool blueMageSkill;
    public bool blueLancerSkill;

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
        transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime), transform.position.y, transform.position.z);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            if (blueArcherSkill == true)
            {
                collision.GetComponent<RedCharScript>().ReceiveDamage(balance.archerDamage);
            }
            if (blueMageSkill == true)
            {
                collision.GetComponent<RedCharScript>().ReceiveDamage(balance.mageDamage);
            }
            if (blueLancerSkill == true)
            {
                collision.GetComponent<RedCharScript>().ReceiveDamage(balance.tankDamage);
                Destroy(gameObject);
            }
        }
        if(collision.transform.tag == "EndScreen")
        {
            Destroy(gameObject);
        }
    }

    


}
