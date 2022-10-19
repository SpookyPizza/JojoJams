using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject panelWin;
    public GameObject panelLose;
    public GameObject panelPause;

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {

    }

    public void SetPause(bool value)
    {
        panelPause.SetActive(value);

        if (value)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }


    public void MyLoadScene(int idScene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(idScene);
        Time.timeScale = 1;
    }

    void Update()
    {

    }


}
