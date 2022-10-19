using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAnim : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetBool("_IsTrigger", true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("_IsTrigger", false);

    }
}
