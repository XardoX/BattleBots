using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private float timeLeft;

    private void Start() {
        SetActivePlayers(false);
        StartCoroutine(StartRound());
        playerOne = playerOneMoves.gameObject;
        playerTwo = playerTwoMove.gameObject;
    }
    private void Update() 
    {
        
    }
    IEnumerator StartRound()
    {
        canvasAnim.SetTrigger("StartCounting");
        FindObjectOfType<AudioManager>().Play("Countdown");
        yield return new WaitForSeconds(3.0f);
        FindObjectOfType<AudioManager>().Play("GameMusic");
        SetActivePlayers(true);
        timeLeft = roundTime;
        yield return new WaitForSeconds(roundTime);
        SetActivePlayers(false);
        canvasAnim.SetTrigger("FadeOUT");
        yield return new WaitForSeconds(2.1f);
        FindObjectOfType<AudioManager>().Play("FixingMusic");
        separateCams.SetActive(true);
        
        SetPlayerTransform(playerOneBox, playerTwoBox);
        SetActivePlayers(true);

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
