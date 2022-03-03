using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click3 : MonoBehaviour
{
    public DataControl dataControl;
    public int downgrade = 0;
    public Text Dopoint;
    public Score score;

    void Awake()
    {
        Dopoint.text = "+0";
    }

    public void Click_downgrade()
    {
        if (Random.Range(1, 100) <= dataControl.success_rate)
        {
            dataControl.IfSuccess();
            downgrade = downgrade + 1;
           // Debug.Log("downgrade: " + downgrade);
            Dopoint.text = "+" + downgrade.ToString();
            
        }
        else
        {
            dataControl.NoSuccess();
        }
        dataControl.DoUpgrade();
        score.scoreUpdate();
        //Debug.Log("success_rate " + dataControl.success_rate);
    }

}
