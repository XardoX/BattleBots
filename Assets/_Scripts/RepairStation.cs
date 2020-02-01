using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairStation : MonoBehaviour
{
    public enum StationType{Health, Attack, Speed};
    public StationType stationType;

    private int stationID, playerID;
    private float statValue;
    private CombatController combat;
    private string playerAxis;
    void Start()
    {
        combat = GameObject.Find("GameManager").GetComponent<CombatController>();
        switch(stationType)
           {
            case StationType.Health:
            stationID = 1;
            break;
            case StationType.Attack:
            stationID = 2;
            break;
            case StationType.Speed:
            stationID = 3;
            break;
            default:
            break;
           }
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetButtonDown("P1 Action"))
      {
          Debug.Log("update");
      }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            playerID = other.GetComponent<PlayerController>().playerID;
            switch(playerID)
            {
                case 0:
                playerAxis = "P1 Action";
                break;
                case 1:
                playerAxis = "P2 Action";
                break;
                default:
                break;

            }
        }
    }
    private void OnTriggerStay(Collider other) 
    {
      if(Input.GetButtonDown(playerAxis))
      {
          Debug.Log("ass");
          combat.RepairStats(playerID, stationID);
      }
    }
    private void OnTriggerExit(Collider other) 
    {
        playerID = 0;
        playerAxis = null;
    }

}
