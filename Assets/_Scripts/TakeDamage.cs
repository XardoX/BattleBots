using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public DamageType damageType;
    public enum DamageType{Health,Attack,LeftTrack,RightTrack}
    private CombatController combat;
    private int damageID;
    public int playerID;
    private void Start() {
        combat = GameObject.Find("GameManager").GetComponent<CombatController>();
        switch(damageType)
           {
            case DamageType.Health:
            damageID = 0;
            break;
            case DamageType.Attack:
            damageID = 1;
            break;
            case DamageType.LeftTrack:
            damageID = 2;
            break;
            case DamageType.RightTrack:
            damageID = 3;
            break;
            default:
            break;
           }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (playerID == 0)
        {
            if(other.gameObject.tag == "AttackTwo")
            {
                combat.DealDamage(damageID,playerID);
            }
        } else if (playerID == 1)
        {
            if(other.gameObject.tag == "Attack")
            {
                combat.DealDamage(damageID,playerID);
            }
        }
    }
}
