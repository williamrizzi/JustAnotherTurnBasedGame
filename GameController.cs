using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public AllyManager allyManager;
    public EnemyManager enemyManager;

    public bool tutorial;
    public bool preparation;
    public bool startTurn;
    public bool victory;
    public bool defeat;
    public bool draw;

    public GameObject progressBar;
    public Sprite[] progressRef;

    public EnemiPositions enemies;
    public bool first;

    public ButtonsController buttonCtrl;

    public GameObject startButton;
    public GameObject resetButton;
    public GameObject restartButton;

    public GameObject tutorialObj;
    public GameObject inGameObj;
    public CameraController cameraCtrl;

    public Text timerText;
    public float startTimer;

    public Text roundsText;
    public int roundsNumber;

    public GameObject endGameObjs;

    public GameObject victoryBanner;
    public GameObject defeatBanner;
    public GameObject drawBanner;

    IEnumerator LetsFinish()
    {
        allyManager.ActiveBuffs();
        enemyManager.ActiveBuffs();
        yield return new WaitForSeconds(1f);
        allyManager.BlueArcherAttack();
        allyManager.BlueMageAttack();
        allyManager.BlueLancerAttack();
                
        if(enemyManager.archerLive == true)
        {
            enemyManager.archer.GetComponent<RedCharScript>().LetsAttack();
        }
        if(enemyManager.mageLive == true)
        {
            enemyManager.mage.GetComponent<RedCharScript>().LetsAttack();
        }
        if(enemyManager.lancerLive == true)
        {
            enemyManager.lancer.GetComponent<RedCharScript>().LetsAttack();
        }
        yield return new WaitForSeconds(3f);
        EndTurn();
    }

    IEnumerator WaitToReTurn()
    {
        yield return new WaitForSeconds(0.2f);
        if (victory == false || defeat == false || draw == false)
        {
            allyManager.StopAuras();
            enemyManager.StopAuras();
            startButton.GetComponent<Button>().interactable = true;
            resetButton.GetComponent<Button>().interactable = true;
            preparation = true;
            startTurn = false;
            first = true;
            buttonCtrl.ResetChars();
            enemies.ResetPositions();
            allyManager.RemoveBuffs();
            enemyManager.RemoveBuffs();
        }
    }

    IEnumerator WaitTransition()
    {
        yield return new WaitForSeconds(0.1f);
        Tutorial();
        yield return new WaitForSeconds(1.2f);
        inGameObj.SetActive(true);
    }

    IEnumerator WaitEndGame()
    {
        yield return new WaitForSeconds(1f);
        if(victory == true)
        {
            victoryBanner.SetActive(true);
        }
        if (defeat == true)
        {
            defeatBanner.SetActive(true);
        }
        if (draw == true)
        {
            drawBanner.SetActive(true);
        }
        endGameObjs.SetActive(true);        
    }


    // Start is called before the first frame update
    void Start()
    {
        tutorialObj.SetActive(true);
        tutorial = true;
        first = false;
        victory = false;
        defeat = false;
        draw = false;
        VictoryBarCheck();
        Tutorial();
    }

    // Update is called once per frame
    void Update()
    {

        if(victory == false && defeat == false && draw == false)
        {
            if(tutorial != true)
            {
                startTimer = startTimer + 1 * Time.deltaTime;

                string minutes = ((int)startTimer / 60).ToString();
                string seconds = (startTimer % 60).ToString("f0");
                timerText.text = minutes + ":" + seconds;

                roundsText.text = roundsNumber.ToString();
            }           

            if (startTurn == true && first == true)
            {
                RunTurn();
                first = false;
                StartCoroutine("LetsFinish");
            }
        }
        if(victory == true)
        {
            preparation = false;
            buttonCtrl.LetsOff();
            startButton.GetComponent<Button>().interactable = false;
            resetButton.GetComponent<Button>().interactable = false;
            Victory();
        }
        if(defeat == true)
        {
            preparation = false;
            buttonCtrl.LetsOff();
            startButton.GetComponent<Button>().interactable = false;
            resetButton.GetComponent<Button>().interactable = false;
            Defeat();
        }
        if(draw == true)
        {
            preparation = false;
            buttonCtrl.LetsOff();
            startButton.GetComponent<Button>().interactable = false;
            resetButton.GetComponent<Button>().interactable = false;
            Draw();
        }        
    }

    public void RunTurn()
    {
        enemies.RandomPosition();
        enemies.SetPositions();
        allyManager.StartAuras();
        enemyManager.StartAuras();
    }

    public void EndTurn()
    {
        VictoryBarCheck();
        StartCoroutine("WaitToReTurn");
    }

    public void VictoryBarCheck()
    {
        if(allyManager.allyCount == 3)
        {
            if(enemyManager.enemyCount == 3)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[2];
            }
            else if(enemyManager.enemyCount == 2)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[1];
            }
            else if (enemyManager.enemyCount == 1)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[1];
            }
            else if (enemyManager.enemyCount == 0)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[0];
                victory = true;
            }
        }
        else if(allyManager.allyCount == 2)
        {
            if (enemyManager.enemyCount == 3)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[3];
            }
            else if (enemyManager.enemyCount == 2)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[2];
            }
            else if (enemyManager.enemyCount == 1)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[1];
            }
            else if (enemyManager.enemyCount == 0)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[0];
                victory = true;
            }
        }
        else if (allyManager.allyCount == 1)
        {
            if (enemyManager.enemyCount == 3)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[3];
            }
            else if (enemyManager.enemyCount == 2)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[3];
            }
            else if (enemyManager.enemyCount == 1)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[2];
            }
            else if (enemyManager.enemyCount == 0)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[0];
                victory = true;
            }
        }
        else if (allyManager.allyCount == 0)
        {
            if (enemyManager.enemyCount == 3)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[4];
                defeat = true;
            }
            else if (enemyManager.enemyCount == 2)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[4];
                defeat = true;
            }
            else if (enemyManager.enemyCount == 1)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[4];
                defeat = true;
            }
            else if (enemyManager.enemyCount == 0)
            {
                progressBar.GetComponent<SpriteRenderer>().sprite = progressRef[2];
                draw = true;
            }
        }
    }

    public void Victory()
    {
        StartCoroutine("WaitEndGame");
    }

    public void Defeat()
    {
        StartCoroutine("WaitEndGame");
    }

    public void Draw()
    {
        StartCoroutine("WaitEndGame");
    }

    public void Tutorial()
    {
        if(tutorial == true)
        {
            preparation = false;
            buttonCtrl.LetsOff();
            startButton.GetComponent<Button>().interactable = false;
            resetButton.GetComponent<Button>().interactable = false;
        }    
        if(tutorial == false)
        {
            preparation = true;
            buttonCtrl.LetsOn();
            startButton.GetComponent<Button>().interactable = true;
            resetButton.GetComponent<Button>().interactable = true;
        }
    }

    public void StartGamePressed()
    {
        tutorial = false;
        tutorialObj.SetActive(false);
        cameraCtrl.inGame = true;
        StartCoroutine("WaitTransition");   
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
