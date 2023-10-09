using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    private int ScorePlayer1 = 0;
    private int ScorePlayer2 = 0;

    public GameObject ScoreTextPlayer1;
    public GameObject ScoreTextPlayer2;

    public int goalToWin;

    // Update is called once per frame
    void Update()
    {
        if (this.ScorePlayer1>=goalToWin|| this.ScorePlayer2>=goalToWin)
        {
            SceneManager.LoadScene("GameOver");
           
        }
    }
    private void FixedUpdate()
    {
        Text uiScoorePlayer1= this.ScoreTextPlayer1.GetComponent<Text>();
        uiScoorePlayer1.text = this.ScorePlayer1.ToString();

        Text uiScoorePlayer2 = this.ScoreTextPlayer2.GetComponent<Text>();
        uiScoorePlayer2.text = this.ScorePlayer2.ToString();
    }
    public void GoalPlayer1()
    { this.ScorePlayer1++; }
    public void GoalPlayer2()
    { this.ScorePlayer2++; }
}
