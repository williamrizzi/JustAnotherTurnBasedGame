using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiPositions : MonoBehaviour
{

    public EnemyManager enemyManager;

    public GameObject red_Archer;
    public GameObject red_Mage;
    public GameObject red_Tank;

    public int random;
    public int lastRandom;


    // Start is called before the first frame update
    void Start()
    {
        lastRandom = -1;
        ResetPositions();
    }

    // Update is called once per frame
    void Update()
    {
        SetLayer();        
    }

    public void RandomPosition()
    {
        random = (int)Random.Range(1, 25);
    }

    public void ResetPositions()
    {
        if (enemyManager.archerLive == true)
        {
            red_Archer.transform.position = new Vector3(5, -1, red_Archer.transform.position.z);
        }
        if (enemyManager.mageLive == true)
        {
            red_Mage.transform.position = new Vector3(5, -2, red_Mage.transform.position.z);
        }
        if (enemyManager.lancerLive == true)
        {
            red_Tank.transform.position = new Vector3(5, -3, red_Tank.transform.position.z);
        }           
    }

    public void SetPositions()
    {        
        if (random == 1)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(2, -1, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(3, -2, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(4, -3, red_Tank.transform.position.z);
            }
        }
        if (random == 2)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(2, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(4, -2, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(4, -3, red_Tank.transform.position.z);
            }
        }
        if (random == 3)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(4, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(3, -1, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 4)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(4, -1, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(4, -2, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(4, -3, red_Tank.transform.position.z);
            }
        }
        if (random == 5)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(3, -3, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(3, -2, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(3, -1, red_Tank.transform.position.z);
            }
        }
        if (random == 6)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(4, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(3, -3, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 7)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(3, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(4, -3, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -1, red_Tank.transform.position.z);
            }
        }
        if (random == 8)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(3, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(2, -3, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 9)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(4, -1, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(3, -1, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(3, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 10)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(3, -3, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(2, -1, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 11)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(2, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(3, -1, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(3, -3, red_Tank.transform.position.z);
            }
        }
        if (random == 12)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(3, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(4, -2, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 13)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(3, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(4, -1, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 14)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(2, -3, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(2, -1, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(4, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 15)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(3, -3, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(3, -1, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(4, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 16)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(3, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(3, -1, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(3, -3, red_Tank.transform.position.z);
            }
        }
        if (random == 17)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(4, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(3, -3, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -3, red_Tank.transform.position.z);
            }
        }
        if (random == 18)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(4, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(4, -3, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 19)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(4, -1, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(4, -3, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(4, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 20)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(3, -2, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(4, -3, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -2, red_Tank.transform.position.z);
            }
        }
        if (random == 21)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(3, -1, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(4, -3, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(3, -3, red_Tank.transform.position.z);
            }
        }
        if (random == 22)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(3, -3, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(2, -1, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(4, -3, red_Tank.transform.position.z);
            }
        }
        if (random == 23)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(4, -3, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(3, -1, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -3, red_Tank.transform.position.z);
            }
        }
        if (random == 24)
        {
            if (enemyManager.archerLive == true)
            {
                red_Archer.transform.position = new Vector3(4, -3, red_Archer.transform.position.z);
            }
            if (enemyManager.mageLive == true)
            {
                red_Mage.transform.position = new Vector3(4, -1, red_Mage.transform.position.z);
            }
            if (enemyManager.lancerLive == true)
            {
                red_Tank.transform.position = new Vector3(2, -2, red_Tank.transform.position.z);
            }
        }
    }

    private void SetLayer()
    {
        if(enemyManager.archerLive == true)
        {
            //Archer
            if (red_Archer.transform.position.y == -1)
            {
                red_Archer.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 6;
            }
            if (red_Archer.transform.position.y == -2)
            {
                red_Archer.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 7;
            }
            if (red_Archer.transform.position.y == -3)
            {
                red_Archer.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 8;
            }
        }
        if (enemyManager.mageLive == true)
        {
            //Mage
            if (red_Mage.transform.position.y == -1)
            {
                red_Mage.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 6;
            }
            if (red_Mage.transform.position.y == -2)
            {
                red_Mage.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 7;
            }
            if (red_Mage.transform.position.y == -3)
            {
                red_Mage.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 8;
            }
        }
        if(enemyManager.lancerLive == true)
        {
            //Tank
            if (red_Tank.transform.position.y == -1)
            {
                red_Tank.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 6;
            }
            if (red_Tank.transform.position.y == -2)
            {
                red_Tank.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 7;
            }
            if (red_Tank.transform.position.y == -3)
            {
                red_Tank.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 8;
            }
        }
    }

}
