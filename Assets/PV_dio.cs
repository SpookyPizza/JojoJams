using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PV_dio : MonoBehaviour
{
    public SpriteRenderer sprite;

   
    
public int point_de_vie_dio;
public BoxCollider2D collider_de_dio;
public BoxCollider2D collider_de_la_boule;
public Animator nb_pv;
public Animator anim_dmg;
public SpriteRenderer Dio_red;

    void Start()
    {
        point_de_vie_dio = 3;
    }

    void OnTriggerEnter2D(Collider2D collider_de_la_boule)
    {
        if (collider_de_la_boule.gameObject.tag == "Ball")
        {
            StartCoroutine(FlashRed());
        }
        point_de_vie_dio -= 1;
        anim_dmg.SetBool("win_jojo", true);
        StartCoroutine(anim_damages());
        Debug.Log(point_de_vie_dio);
        if (point_de_vie_dio == 0)
        {
            //fin du match 
            Debug.Log("Victoire de Jotaro");
            SceneManager.LoadScene("victoire_jojo");
        }
        if (point_de_vie_dio == 2)
        {
            nb_pv.SetInteger("valeur_pv_dio", 2);
        }
        if (point_de_vie_dio == 1)
        {
            nb_pv.SetInteger("valeur_pv_dio", 1);
        }
    }
    public IEnumerator FlashRed()
    {
        Debug.Log("flashmevoila");
        Dio_red.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        Dio_red.color = Color.white;
    }

    IEnumerator anim_damages()
    {
        Debug.Log("j'attend");
        yield return new WaitForSeconds(1);
        anim_dmg.SetBool("win_jojo", false);
    }
}
