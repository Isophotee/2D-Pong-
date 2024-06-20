using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject panelWin;
    public GameObject panelLose;
    public  int PlayerScoreL = 0;
    public  int PlayerScoreR = 0;

    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;
    
    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
        panelWin.SetActive(false);
        panelLose.SetActive(false);
    }


    public void Score(string wallID)
    {
        if (wallID == "playerGoal")
        {
            PlayerScoreR = PlayerScoreR + 1;
            txtPlayerScoreR.text = PlayerScoreR.ToString();
            checkScore();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 1;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            checkScore();
        }
    }

    public void checkScore()
    {
        if (PlayerScoreL == 3)
        {
            panelWin.SetActive(true);
        }
        else if (PlayerScoreR == 3)
        {
            panelLose.SetActive(true);
        }
    }

}