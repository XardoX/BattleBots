using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public int playerID;
    public Animator anim;
    public bool canDamage;
    private int AttackedPlayerID;
    int statID;
    TakeDamage takeDamage;
    string playerAxis;

    void Start ()
    {
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

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown(playerAxis))
        {
            canDamage = true;
            Attack();
        }
    }

    private void Attack()
    {
        anim.SetTrigger ("Attack");
    }
   private void OnTriggerEnter(Collider other) 
   {
       if (canDamage)
       {
           //Debug.Log(other.gameObject.name);
            if (other.gameObject.tag == "Damagable")
            {
                Debug.Log("Damagable");
                takeDamage = other.gameObject.GetComponent<TakeDamage>();
                AttackedPlayerID = takeDamage.playerID;
                statID = takeDamage.damageID;
                Debug.Log(other.gameObject.name + " playerID "+AttackedPlayerID+ "  dmgID " + statID);
                CombatController.Instance.DealDamage(statID,AttackedPlayerID);
                canDamage = false;
            }
       }
   }
}
