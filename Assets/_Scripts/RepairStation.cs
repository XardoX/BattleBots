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
    private bool inStation;
    void Start()
    {
        combat = CombatController.Instance;
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
        if(inStation)
        {
            if(Input.GetButtonDown(playerAxis))
            {
                combat.RepairStats(playerID, stationID);
                Debug.Log("Repair");
                FindObjectOfType<AudioManager>().Play("Upgrade");
            }
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
                playerAxis = "P1 Use";
                break;
                case 1:
                playerAxis = "P2 Use";
                break;
                default:
                break;

            }
            inStation = true;
        }
    }
   
    private void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
             playerID = 0;
            playerAxis = null;
            inStation = false;
        }
    }

}
