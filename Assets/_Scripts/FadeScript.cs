using UnityEngine;

public class FadeScript : MonoBehaviour
{

    public Animator animator;

   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("FadeIN");
            Debug.Log("Dziala");

        }
        if (Input.GetMouseButtonDown(1))
        {
            animator.SetTrigger("FadeOUT");
            Debug.Log("Dziala");
        }
    }
}
