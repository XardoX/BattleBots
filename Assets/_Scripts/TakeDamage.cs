using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public DamageType damageType;
    public enum DamageType{Health,Attack,LeftTrack,RightTrack}

    private void OnTriggerEnter(Collider other) 
    {
        
    }
}
