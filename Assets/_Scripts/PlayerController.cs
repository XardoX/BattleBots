using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerID;
    public Animator anim;

    void Start ()
    {
        //anim = GetComponent<Animator>();
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    private void Attack()
    {
        anim.SetTrigger ("Attack");
    }
}
