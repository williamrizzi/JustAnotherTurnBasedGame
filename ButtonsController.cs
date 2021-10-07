using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsController : MonoBehaviour
{

    public GameController gameCtrl;

    public GameObject allButtons;

    public Raycast ray;

    public bool p1Status;
    public bool p2Status;
    public bool p3Status;
    public bool p4Status;
    public bool p5Status;
    public bool p6Status;
    public bool p7Status;
    public bool p8Status;
    public bool p9Status;

    public GameObject[] buttons;   

    // Start is called before the first frame update
    void Start()
    {
        ResetStatus();
    }

    // Update is called once per frame
    void Update()
    {
        PosButtonOff();   
    }


    public void StartTurn()
    {
        gameCtrl.roundsNumber += 1;
        if(ray.setArcher == true && ray.setMage == true && ray.setTank == true)
        {
            gameCtrl.startButton.GetComponent<Button>().interactable = false;
            gameCtrl.resetButton.GetComponent<Button>().interactable = false;
            gameCtrl.preparation = false;
            gameCtrl.startTurn = true;
            gameCtrl.first = true;            
        }        
    }

    public void ResetChars()
    {
        if(gameCtrl.preparation == true)
        {
            ray.ResetPositions();
            ResetStatus();
            PosButtonOn();
        }        
    }

    public void PosButtonOn()
    {       
        buttons[0].gameObject.SetActive(true);
        buttons[1].gameObject.SetActive(true);
        buttons[2].gameObject.SetActive(true);
        buttons[3].gameObject.SetActive(true);
        buttons[4].gameObject.SetActive(true);
        buttons[5].gameObject.SetActive(true);
        buttons[6].gameObject.SetActive(true);
        buttons[7].gameObject.SetActive(true);
        buttons[8].gameObject.SetActive(true);
        
    }

    public void PosButtonOff()
    {
        if(ray.setArcher == true && ray.setMage == true && ray.setTank == true)
        {
            buttons[0].gameObject.SetActive(false);
            buttons[1].gameObject.SetActive(false);
            buttons[2].gameObject.SetActive(false);
            buttons[3].gameObject.SetActive(false);
            buttons[4].gameObject.SetActive(false);
            buttons[5].gameObject.SetActive(false);
            buttons[6].gameObject.SetActive(false);
            buttons[7].gameObject.SetActive(false);
            buttons[8].gameObject.SetActive(false);            
        }
    }

    public void LetsOff()
    {
        allButtons.SetActive(false);
    }

    public void LetsOn()
    {
        allButtons.SetActive(true);
    }

    public void ResetStatus()
    {
        p1Status = p2Status = p3Status = p4Status = p5Status = p6Status = p7Status = p8Status = p9Status = false;
    }

    public void P1Pressed()
    {
        if (ray.letsMove == Raycast.MoveToPiece.archer && p1Status == false && ray.setArcher == false)
        {
            ray.blueArcher.transform.position = new Vector3(-4f, -1f, ray.blueArcher.transform.position.z);
            p1Status = true;
            ray.setArcher = true;
            buttons[0].gameObject.SetActive(false);
        }
        if(ray.letsMove == Raycast.MoveToPiece.mage && p1Status == false && ray.setMage == false)
        {
            ray.blueMage.transform.position = new Vector3(-4f, -1f, ray.blueMage.transform.position.z);
            p1Status = true;
            ray.setMage = true;
            buttons[0].gameObject.SetActive(false);
        }
        if(ray.letsMove == Raycast.MoveToPiece.tank && p1Status == false && ray.setTank == false)
        {
            ray.blueTank.transform.position = new Vector3(-4f, -1f, ray.blueTank.transform.position.z);
            p1Status = true;
            ray.setTank = true;
            buttons[0].gameObject.SetActive(false);
        }
        ray.letsMove = Raycast.MoveToPiece.empty;
    }
    public void P2Pressed()
    {
        if (ray.letsMove == Raycast.MoveToPiece.archer && p2Status == false && ray.setArcher == false)
        {
            ray.blueArcher.transform.position = new Vector3(-3f, -1f, ray.blueArcher.transform.position.z);
            p2Status = true;
            ray.setArcher = true;
            buttons[1].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.mage && p2Status == false && ray.setMage == false)
        {
            ray.blueMage.transform.position = new Vector3(-3f, -1f, ray.blueMage.transform.position.z);
            p2Status = true;
            ray.setMage = true;
            buttons[1].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.tank && p2Status == false && ray.setTank == false)
        {
            ray.blueTank.transform.position = new Vector3(-3f, -1f, ray.blueTank.transform.position.z);
            p2Status = true;
            ray.setTank = true;
            buttons[1].gameObject.SetActive(false);
        }
        ray.letsMove = Raycast.MoveToPiece.empty;
    }
    public void P3Pressed()
    {
        if (ray.letsMove == Raycast.MoveToPiece.archer && p3Status == false && ray.setArcher == false)
        {
            ray.blueArcher.transform.position = new Vector3(-2f, -1f, ray.blueArcher.transform.position.z);
            p3Status = true;
            ray.setArcher = true;
            buttons[2].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.mage && p3Status == false && ray.setMage == false)
        {
            ray.blueMage.transform.position = new Vector3(-2f, -1f, ray.blueMage.transform.position.z);
            p3Status = true;
            ray.setMage = true;
            buttons[2].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.tank && p3Status == false && ray.setTank == false)
        {
            ray.blueTank.transform.position = new Vector3(-2f, -1f, ray.blueTank.transform.position.z);
            p3Status = true;
            ray.setTank = true;
            buttons[2].gameObject.SetActive(false);
        }
        ray.letsMove = Raycast.MoveToPiece.empty;
    }
    public void P4Pressed()
    {
        if (ray.letsMove == Raycast.MoveToPiece.archer && p4Status == false && ray.setArcher == false)
        {
            ray.blueArcher.transform.position = new Vector3(-4f, -2f, ray.blueArcher.transform.position.z);
            p4Status = true;
            ray.setArcher = true;
            buttons[3].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.mage && p4Status == false && ray.setMage == false)
        {
            ray.blueMage.transform.position = new Vector3(-4f, -2f, ray.blueMage.transform.position.z);
            p4Status = true;
            ray.setMage = true;
            buttons[3].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.tank && p4Status == false && ray.setTank == false)
        {
            ray.blueTank.transform.position = new Vector3(-4f, -2f, ray.blueTank.transform.position.z);
            p4Status = true;
            ray.setTank = true;
            buttons[3].gameObject.SetActive(false);
        }
        ray.letsMove = Raycast.MoveToPiece.empty;
    }
    public void P5Pressed()
    {
        if (ray.letsMove == Raycast.MoveToPiece.archer && p5Status == false && ray.setArcher == false)
        {
            ray.blueArcher.transform.position = new Vector3(-3f, -2f, ray.blueArcher.transform.position.z);
            p5Status = true;
            ray.setArcher = true;
            buttons[4].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.mage && p5Status == false && ray.setMage == false)
        {
            ray.blueMage.transform.position = new Vector3(-3f, -2f, ray.blueMage.transform.position.z);
            p5Status = true;
            ray.setMage = true;
            buttons[4].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.tank && p5Status == false && ray.setTank == false)
        {
            ray.blueTank.transform.position = new Vector3(-3f, -2f, ray.blueTank.transform.position.z);
            p5Status = true;
            ray.setTank = true;
            buttons[4].gameObject.SetActive(false);
        }
        ray.letsMove = Raycast.MoveToPiece.empty;
    }
    public void P6Pressed()
    {
        if (ray.letsMove == Raycast.MoveToPiece.archer && p6Status == false && ray.setArcher == false)
        {
            ray.blueArcher.transform.position = new Vector3(-2f, -2f, ray.blueArcher.transform.position.z);
            p6Status = true;
            ray.setArcher = true;
            buttons[5].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.mage && p6Status == false && ray.setMage == false)
        {
            ray.blueMage.transform.position = new Vector3(-2f, -2f, ray.blueMage.transform.position.z);
            p6Status = true;
            ray.setMage = true;
            buttons[5].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.tank && p6Status == false && ray.setTank == false)
        {
            ray.blueTank.transform.position = new Vector3(-2f, -2f, ray.blueTank.transform.position.z);
            p6Status = true;
            ray.setTank = true;
            buttons[5].gameObject.SetActive(false);
        }
        ray.letsMove = Raycast.MoveToPiece.empty;
    }
    public void P7Pressed()
    {
        if (ray.letsMove == Raycast.MoveToPiece.archer && p7Status == false && ray.setArcher == false)
        {
            ray.blueArcher.transform.position = new Vector3(-4f, -3f, ray.blueArcher.transform.position.z);
            p7Status = true;
            ray.setArcher = true;
            buttons[6].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.mage && p7Status == false && ray.setMage == false)
        {
            ray.blueMage.transform.position = new Vector3(-4f, -3f, ray.blueMage.transform.position.z);
            p7Status = true;
            ray.setMage = true;
            buttons[6].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.tank && p7Status == false && ray.setTank == false)
        {
            ray.blueTank.transform.position = new Vector3(-4f, -3f, ray.blueTank.transform.position.z);
            p7Status = true;
            ray.setTank = true;
            buttons[6].gameObject.SetActive(false);
        }
        ray.letsMove = Raycast.MoveToPiece.empty;
    }
    public void P8Pressed()
    {
        if (ray.letsMove == Raycast.MoveToPiece.archer && p8Status == false && ray.setArcher == false)
        {
            ray.blueArcher.transform.position = new Vector3(-3f, -3f, ray.blueArcher.transform.position.z);
            p8Status = true;
            ray.setArcher = true;
            buttons[7].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.mage && p8Status == false && ray.setMage == false)
        {
            ray.blueMage.transform.position = new Vector3(-3f, -3f, ray.blueMage.transform.position.z);
            p8Status = true;
            ray.setMage = true;
            buttons[7].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.tank && p8Status == false && ray.setTank == false)
        {
            ray.blueTank.transform.position = new Vector3(-3f, -3f, ray.blueTank.transform.position.z);
            p8Status = true;
            ray.setTank = true;
            buttons[7].gameObject.SetActive(false);
        }
        ray.letsMove = Raycast.MoveToPiece.empty;
    }
    public void P9Pressed()
    {
        if (ray.letsMove == Raycast.MoveToPiece.archer && p9Status == false && ray.setArcher == false)
        {
            ray.blueArcher.transform.position = new Vector3(-2f, -3f, ray.blueArcher.transform.position.z);
            p9Status = true;
            ray.setArcher = true;
            buttons[8].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.mage && p9Status == false && ray.setMage == false)
        {
            ray.blueMage.transform.position = new Vector3(-2f, -3f, ray.blueMage.transform.position.z);
            p9Status = true;
            ray.setMage = true;
            buttons[8].gameObject.SetActive(false);
        }
        if (ray.letsMove == Raycast.MoveToPiece.tank && p9Status == false && ray.setTank == false)
        {
            ray.blueTank.transform.position = new Vector3(-2f, -3f, ray.blueTank.transform.position.z);
            p9Status = true;
            ray.setTank = true;
            buttons[8].gameObject.SetActive(false);
        }
        ray.letsMove = Raycast.MoveToPiece.empty;
    }
}
