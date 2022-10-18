using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PV_Jotaro : MonoBehaviour
{
public int point_de_vie_jojo;
public BoxCollider2D collider_de_jojo;
public BoxCollider2D collider_de_la_boule;
public Animator nb_pv;

    void Start()
    {
        point_de_vie_jojo = 3;
    }

    void OnTriggerEnter2D(Collider2D collider_de_la_boule)
    {
        point_de_vie_jojo -= 1;
        Debug.Log(point_de_vie_jojo);
        if (point_de_vie_jojo == 0)
        {
            //fin du match 
            Debug.Log("Victoire de DIO");
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
}
