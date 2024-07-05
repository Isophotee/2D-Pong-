using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
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
    }


    public void Score(string wallID)
    {
        if (wallID == "Wall_Player1")
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
        if (PlayerScoreL == 5)
        {
            Debug.Log("playerL win");
            this.gameObject.SendMessage("ChangeScene","StartScene");
        }
        else if (PlayerScoreR == 5)
        {
            Debug.Log("playerR win");
            this.gameObject.SendMessage("ChangeScene", "");
        }
    }
}