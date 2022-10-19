using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager_de_victoire : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("rejouer");
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("menu");
            SceneManager.LoadScene("SceneMenu");
        }
    }
}
