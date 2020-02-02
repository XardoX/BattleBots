using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CombatController : MonoBehaviour
{
    private static CombatController _instance;
    public static CombatController Instance {get{return _instance;}}
    [SerializeField]
    public PlayerStats[] player;
    public int[] healthValues;
    public int[] attackValues;
    public float[] speedValues,rotateValues;
    public bool isEndGame;
    public int winnerID;
    private RobotMovement movementOne;
    private RobotMovement1 movementTwo;

    private int repairValue;

    private int[] currentDamage;

    private void Awake() 
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }
    void Start()
    {
        movementOne = player[0].playerObject.GetComponent<RobotMovement>();
        movementTwo = player[1].playerObject.GetComponent<RobotMovement1>();
        SetStats(0);
        SetStats(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (player[0].currentHealth <= 0)
        {
            EndGame(0);
        }
         if (player[1].currentHealth <= 0)
        {
            EndGame(1);
        }
    }

    void StartFight()
    {
        
    }

    void SetStats(int playerID)
    {
        if (playerID == 0)
        {
            movementOne.SetSpeedlvl(speedValues[player[0].leftSpeed],speedValues[player[0].rightSpeed], rotateValues[player[0].leftSpeed], rotateValues[player[0].rightSpeed]);
        } else if (playerID == 1)
        {
            movementTwo.SetSpeedlvl(speedValues[player[1].leftSpeed],speedValues[player[1].rightSpeed],rotateValues[player[1].leftSpeed], rotateValues[player[1].rightSpeed]);
        }
        player[playerID].currentHealth = healthValues[player[playerID].healthLevel];
        player[playerID].healthText.text = player[playerID].currentHealth.ToString();
        player[playerID].attackText.text = (player[playerID].attackLevel+1).ToString();
        player[playerID].leftText.text = (player[playerID].leftSpeed+1).ToString();
        player[playerID].rightText.text = (player[playerID].rightSpeed+1).ToString();

    }
    public void DealDamage(int damageID, int damagedID)
    {
            switch(damageID)
            {
                case 0://health
                    DecreaseStat(damageID,damagedID);
                    break;
                case 1://attack
                    DecreaseStat(damageID,damagedID);
                    break;
                case 2://lefttrack
                    DecreaseStat(damageID,damagedID);
                    break;
                case 3://righttrack
                    DecreaseStat(damageID,damagedID);
                    break;
                default:
                break;
            }
        
    }
    public void DecreaseStat(int statID, int playerID)
    {
        
        switch(statID)
        {
            case 1:
                
                player[playerID].currentHealth--;
                player[playerID].healthText.text = player[playerID].currentHealth.ToString();
                if(player[playerID].healthLevel == 0)
                {
                    if (player[playerID].currentHealth <= 0)
                    {
                        EndGame(playerID);
                    }
                }else if (player[playerID].currentHealth <= healthValues[player[playerID].healthLevel-1])
                {
                    player[playerID].healthLevel--;
                    player[playerID].currentHealth = healthValues[player[playerID].healthLevel];
                    SetStats(playerID);
                }

                break;
            case 2:
                if(player[playerID].attackLevel >= 1) 
                {
                    player[playerID].attackLevel--;
                    SetStats(playerID);
                }
                break;
            case 3:
                if(player[playerID].leftSpeed >= 1) 
                {
                    player[playerID].leftSpeed--;
                    SetStats(playerID);
                }
                break;
            case 4:
                if(player[playerID].rightSpeed >= 1) 
                {
                    player[playerID].rightSpeed--;
                    SetStats(playerID);
                }
                
                break;
            default:
            break;
        }
    }
    #region  Repair
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
        SetStats(playerID);
    }
    public void UpgradeStat(int statID, int playerID)
    {
        switch(statID)
        {
            case 1:
            if(player[playerID].healthLevel < 4) 
            {
                player[playerID].healthLevel++;
                SetStats(playerID);
            }
            break;
            case 2:
            if(player[playerID].attackLevel < 4) 
            {
                player[playerID].attackLevel++;
                SetStats(playerID);
            }
            break;
            case 3:
            if(player[playerID].leftSpeed < player[playerID].rightSpeed)
            {
                if(player[playerID].leftSpeed < 4) 
                {
                    player[playerID].leftSpeed++;
                    SetStats(playerID);
                }
            }else if(player[playerID].leftSpeed > player[playerID].rightSpeed)
            {
               if(player[playerID].rightSpeed < 4) 
               {
                   player[playerID].rightSpeed++;
                   SetStats(playerID);
               }
            } else if(player[playerID].leftSpeed == player[playerID].rightSpeed)
            {
                if(player[playerID].leftSpeed < 4 && player[playerID].rightSpeed < 4)
                {
                    player[playerID].rightSpeed++;
                    player[playerID].leftSpeed++;
                    SetStats(playerID);
                }
            }
            break;
            default:
            break;
        }
    }
        #endregion

    void EndGame(int loserID)
    {
        Debug.Log("Endgema");
        if (loserID == 0)
        {
            //loserID = 1;
        }
        else if (loserID == 1)
        {
            //loserID = 0;        
            }
        winnerID = loserID;
        isEndGame = true;
    }
}
[System.Serializable]
public class PlayerStats
{
    public GameObject playerObject;
    public int currentHealth;
    public int healthLevel;
    public int attackLevel;
    public int leftSpeed;
    public int rightSpeed;

    public TextMeshProUGUI healthText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI leftText;
    public TextMeshProUGUI rightText;

}
