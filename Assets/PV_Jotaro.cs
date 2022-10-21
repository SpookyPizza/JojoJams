using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PV_Jotaro : MonoBehaviour
{
    public SpriteRenderer sprite;
    public int point_de_vie_jojo;
public BoxCollider2D collider_de_jojo;
public BoxCollider2D collider_de_la_boule;
public Animator nb_pv;
public Animator anim_dmg;
public SpriteRenderer Jotaro_red;

    void Start()
    {
        point_de_vie_jojo = 3;
    }

    void OnTriggerEnter2D(Collider2D collider_de_la_boule)
    {
        if (collider_de_la_boule.gameObject.tag == "Ball")
        {
            StartCoroutine(FlashRed());
        }
        point_de_vie_jojo -= 1;
        anim_dmg.SetBool("win_dio", true);
        StartCoroutine(anim_damages());
        Debug.Log(point_de_vie_jojo);
        if (point_de_vie_jojo == 0)
        {
            //fin du match 
            Debug.Log("Victoire de DIO");
            SceneManager.LoadScene("victoire_dio");
        }
        if (point_de_vie_jojo == 2)
        {
            nb_pv.SetInteger("valeur_pv_jojo", 2);
        }
        if (point_de_vie_jojo == 1)
        {
            nb_pv.SetInteger("valeur_pv_jojo", 1);
        }
    }
    public IEnumerator FlashRed()
    {
        Debug.Log("flashmevoila");
        Jotaro_red.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        Jotaro_red.color = Color.white;
    }

    IEnumerator anim_damages()
    {
        Debug.Log("j'attend");
        yield return new WaitForSeconds(1);
        anim_dmg.SetBool("win_dio", false);
    }
}
