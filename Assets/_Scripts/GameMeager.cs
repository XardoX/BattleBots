using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMeager : MonoBehaviour
{

    public GameObject Bot;
    public GameObject Gate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Bot.health <= 0 )
        {

            Gate.gameObject.SetActive(false);


        }
    }
}
