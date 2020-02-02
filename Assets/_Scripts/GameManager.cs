using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform playerOneArena, playerOneBox, playerTwoArena, playerTwoBox;
    public GameObject separateCams, redWon, blueWon;
    public Animator canvasAnim;
    public RobotMovement playerOneMoves;
    public RobotMovement1 playerTwoMove;

    private GameObject playerOne, playerTwo;
    public float roundTime;
    public float repairTime;
    public TextMeshProUGUI timerText;
    private float timerLeft;

    private void Start() 
    {
        SetActivePlayers(false);
        StartCoroutine(StartRound());
        playerOne = playerOneMoves.gameObject;
        playerTwo = playerTwoMove.gameObject;
    }
    private void Update() 
    {
        
        if ( timerLeft <= 0 )
        {
            timerLeft = 0;
        } else 
        {
            timerLeft -= Time.deltaTime;
        }
        timerText.text = timerLeft.ToString("F0");

        if(CombatController.Instance.isEndGame)
        {
            StopCoroutine(StartRound());
            StartCoroutine(FinishGame());
        }
    }
    IEnumerator StartRound()
    {
        while(!CombatController.Instance.isEndGame)
        {
            canvasAnim.SetTrigger("StartCounting");
            Debug.Log("Before");
            yield return new WaitForSeconds(3.1f);
            Debug.Log("after");
            SetActivePlayers(true);
            timerLeft = roundTime;
            yield return new WaitForSeconds(roundTime);
            SetActivePlayers(false);
            canvasAnim.SetTrigger("FadeOUT");
            yield return new WaitForSeconds(1.1f);
            separateCams.SetActive(true);
            
            SetPlayerTransform(playerOneBox, playerTwoBox);
            canvasAnim.SetTrigger("StartCounting");
            yield return new WaitForSeconds(3.1f);
            timerLeft = repairTime;
            SetActivePlayers(true);
            yield return new WaitForSeconds(repairTime);
            SetActivePlayers(false);
            canvasAnim.SetTrigger("FadeOUT");
            yield return new WaitForSeconds(1.1f);
            separateCams.SetActive(false);
            SetPlayerTransform(playerOneArena, playerTwoArena);
        }
        StartCoroutine(FinishGame());
    }

    IEnumerator FinishGame()
    {
        Debug.Log("Finish");
        switch(CombatController.Instance.winnerID)
        {
            case 0:
            redWon.SetActive(true);
            break;
            case 1:
            blueWon.SetActive(true);
            break;
            default:
            break;
        }
        yield return new WaitForSecondsRealtime(7f);
        SceneManager.LoadSceneAsync("Menu");
    }
    void SetPlayerTransform(Transform OnePos, Transform TwoPos)
    {
        playerOne.transform.position = OnePos.position;
        playerOne.transform.rotation = OnePos.rotation;
        playerTwo.transform.position = TwoPos.position;
        playerTwo.transform.rotation = TwoPos.rotation;
    }
    void SetActivePlayers(bool set)
    {
        playerOneMoves.enabled = set;
        playerTwoMove.enabled = set;
    }
}
