using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click2 : MonoBehaviour
{
    public DataControl dataControl;
    public int second_upgrade = 0;
    public Text Uppoint_2;
    public Score score;


    void Awake()
    {
        Uppoint_2.text = "+0";
    }

    public void Click_secondup()
    {
        if (Random.Range(1, 100) <= dataControl.success_rate)
        {
            dataControl.IfSuccess();
            second_upgrade = second_upgrade + 1;
            //Debug.Log("second_upgrade: " + second_upgrade);
            Uppoint_2.text = "+" + second_upgrade.ToString();
            
        }
        else
        {
            dataControl.NoSuccess();
        }
        
        dataControl.DoUpgrade();
        score.scoreUpdate();
       // Debug.Log("success_rate " + dataControl.success_rate);
    }

}
