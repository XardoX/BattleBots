using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    [SerializeField]
    public PlayerStats[] player;
    public float[] healthValues;
    public float[] attackValues;
    public float[] speedValues,rotateValues;
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
        movementOne.SetSpeedlvl(speedValues[player[0].leftSpeed],speedValues[player[0].rightSpeed], rotateValues[player[0].leftSpeed], rotateValues[player[0].rightSpeed]);
        movementTwo.SetSpeedlvl(speedValues[player[1].leftSpeed],speedValues[player[1].rightSpeed],rotateValues[player[1].leftSpeed], rotateValues[player[1].rightSpeed]);
    }

    public void RepairStats(int playerID, int statID)
    {
        int statlevel = 0;
        switch(statID)
        {
            case 1:
            statlevel = (player[playerID].healthLevel)*5;
            break;
            case 2:
            statlevel = (player[playerID].attackLevel)*5;
            break;
            case 3:
            if(player[playerID].leftSpeed < player[playerID].rightSpeed)
            {
                statlevel = (player[playerID].leftSpeed)*5;
            }else
            {
                statlevel = (player[playerID].rightSpeed)*5;
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
            if(player[playerID].healthLevel < 4) 
            {
                player[playerID].healthLevel++;
                SetStats();
            }
            break;
            case 2:
            if(player[playerID].attackLevel < 4) 
            {
                player[playerID].attackLevel++;
                SetStats();
            }
            break;
            case 3:
            if(player[playerID].leftSpeed < player[playerID].rightSpeed)
            {
                if(player[playerID].leftSpeed < 4) 
                {
                    player[playerID].leftSpeed++;
                    SetStats();
                }
            }else if(player[playerID].leftSpeed > player[playerID].rightSpeed)
            {
               if(player[playerID].rightSpeed < 4) 
               {
                   player[playerID].rightSpeed++;
                   SetStats();
               }
            } else if(player[playerID].leftSpeed == player[playerID].rightSpeed)
            {
                if(player[playerID].leftSpeed < 4 && player[playerID].rightSpeed < 4)
                {
                    player[playerID].rightSpeed++;
                    player[playerID].leftSpeed++;
                    SetStats();
                }
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
