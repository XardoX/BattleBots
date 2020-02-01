using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    [SerializeField]
    public PlayerStats[] player;
    public int[] healthValues;
    public int[] attackValues;
    public int[] speedValues;
    private RobotMovement movementOne;
    private RobotMovement1 movementTwo;

    private int repairValue;

    void Start()
    {
        movementOne = player[0].playerObject.GetComponent<RobotMovement>();
        movementTwo = player[1].playerObject.GetComponent<RobotMovement1>();
        SetStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartFight()
    {
        
    }

    void SetStats()
    {
        movementOne.SetSpeedlvl(speedValues[player[0].leftSpeed],speedValues[player[0].rightSpeed]);
        movementTwo.SetSpeedlvl(speedValues[player[1].leftSpeed],speedValues[player[1].rightSpeed]);
    }

    public void RepairStats(int playerID, int statID)
    {
        int statlevel = 0;
        switch(statID)
        {
            case 1:
            statlevel = player[playerID].healthLevel;
            break;
            case 2:
            statlevel = player[playerID].attackLevel;
            break;
            case 3:
            if(player[playerID].leftSpeed < player[playerID].rightSpeed)
            {
                statlevel = player[playerID].leftSpeed;
            }else
            {
                statlevel = player[playerID].rightSpeed;
            }
            break;
            default:
            break;
        }
        repairValue++;
        if (repairValue >= statlevel)
        {
            UpgradeStat(statID,playerID);
            repairValue = 0;
        }
    }
    public void UpgradeStat(int statID, int playerID)
    {
        switch(statID)
        {
            case 1:
            player[playerID].healthLevel++;
            break;
            case 2:
            player[playerID].attackLevel++;
            break;
            case 3:
            if(player[playerID].leftSpeed < player[playerID].rightSpeed)
            {
                player[playerID].leftSpeed++;
            }else if(player[playerID].leftSpeed > player[playerID].rightSpeed)
            {
                player[playerID].rightSpeed++;
            } else if(player[playerID].leftSpeed == player[playerID].rightSpeed)
            {
                player[playerID].rightSpeed++;
                player[playerID].leftSpeed++;
            }
            break;
            default:
            break;
        }
    }
}
[System.Serializable]
public class PlayerStats
{
    public GameObject playerObject;
    public int healthLevel;
    public int attackLevel;
    public int leftSpeed;
    public int rightSpeed;
}
