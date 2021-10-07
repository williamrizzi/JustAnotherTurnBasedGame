using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public AllyManager allyManager;

    public enum MoveToPiece
    {
        empty, archer, mage, tank
    }

    public MoveToPiece letsMove;    

    public Camera cam;
    public GameController gameCtrl;

    public GameObject blueArcher;
    public GameObject blueMage;
    public GameObject blueTank;

    public GameObject blueArcherIcon;
    public GameObject blueMageIcon;
    public GameObject blueTankIcon;

    public bool setArcher;
    public bool setMage;
    public bool setTank;


    private void Update()
    {
        if(gameCtrl.preparation == true)
        {
            if(setArcher != true || setMage != true || setTank != true)
            {
                RayCast();
            }
        }
        if (letsMove == MoveToPiece.empty)
        {
            IconSelect();
        }
    }

    public void RayCast()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;
            Vector3 screenPos = cam.ScreenToWorldPoint(mousePos);
            RaycastHit2D hit = Physics2D.Raycast(screenPos, Vector2.zero);
            if (hit.collider.gameObject.tag == "Archer" && setArcher == false)
            {
                letsMove = MoveToPiece.archer;
                IconSelect();
                Debug.Log("Archer");
            }
            else if (hit.collider.gameObject.tag == "Mage" && setMage == false)
            {
                letsMove = MoveToPiece.mage;
                IconSelect();
                Debug.Log("Mage");
            }
            else if (hit.collider.gameObject.tag == "Tank" && setTank == false)
            {
                letsMove = MoveToPiece.tank;
                IconSelect();
                Debug.Log("Tank");
            }
        }
    }

    public void ResetPositions()
    {
        if(allyManager.archerLive == true)
        {
            blueArcher.transform.position = new Vector3(-5f, -1f, transform.position.z);
            setArcher = false;
        }
        if (allyManager.mageLive == true)
        {
            blueMage.transform.position = new Vector3(-5f, -2f, transform.position.z);
            setMage = false;
        }            
        if (allyManager.lancerLive == true)
        {
            blueTank.transform.position = new Vector3(-5f, -3f, transform.position.z);
            setTank = false;
        }            
        letsMove = MoveToPiece.empty;
    }

    public void IconSelect()
    {
        if(letsMove == MoveToPiece.archer)
        {
            blueArcherIcon.GetComponent<Animator>().SetBool("Select", true);
            blueMageIcon.GetComponent<Animator>().SetBool("Select", false);
            blueTankIcon.GetComponent<Animator>().SetBool("Select", false);
        }
        else if(letsMove == MoveToPiece.mage)
        {
            blueArcherIcon.GetComponent<Animator>().SetBool("Select", false);
            blueMageIcon.GetComponent<Animator>().SetBool("Select", true);
            blueTankIcon.GetComponent<Animator>().SetBool("Select", false);
        }
        else if(letsMove == MoveToPiece.tank)
        {
            blueArcherIcon.GetComponent<Animator>().SetBool("Select", false);
            blueMageIcon.GetComponent<Animator>().SetBool("Select", false);
            blueTankIcon.GetComponent<Animator>().SetBool("Select", true);
        }
        else if(letsMove == MoveToPiece.empty)
        {
            blueArcherIcon.GetComponent<Animator>().SetBool("Select", false);
            blueMageIcon.GetComponent<Animator>().SetBool("Select", false);
            blueTankIcon.GetComponent<Animator>().SetBool("Select", false);
        }
    }





}
