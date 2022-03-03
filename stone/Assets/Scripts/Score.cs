using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public DataControl dataControl;
    public Click1 click1;
    public Click2 click2;
    public Click3 click3;
    public Text Scoreboard;
    public int score = 0;
    void Awake()
    {
        Scoreboard.text = "+0";
    }
    void Update()
    {
        
    }

    public void scoreUpdate()
    {
        score = (click1.first_upgrade + click2.second_upgrade + click3.downgrade)*100 - dataControl.fail_count * 50;
        if (dataControl.success_count >= 3)
        {
            score = score + dataControl.success_count * 10;
        }
        Scoreboard.text = score.ToString();

    }


}
