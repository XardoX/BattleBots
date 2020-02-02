using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Transform playerOneArena, playerOneBox, playerTwoArena, playerTwoBox;
    public GameObject separateCams;
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
