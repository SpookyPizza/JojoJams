using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAnim : MonoBehaviour
{
    public Animator anim;
    public GameObject stand_rush;

    void Start()
    {
        anim = stand_rush.GetComponent<Animator>();

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            anim.SetBool("_IsTrigger", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            anim.SetBool("_IsTrigger", false);
        }
    }
}
