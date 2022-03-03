using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click1 : MonoBehaviour
{
    public int first_upgrade = 0;
    public Text Uppoint_1;
    public DataControl dataControl;
    public Score score;

    void Awake()
    {
        Uppoint_1.text = "+0";
    }


    public void Click_firstup()
    {
        if(Random.Range(1,100) <= dataControl.success_rate)
        {
            dataControl.IfSuccess();
            first_upgrade = first_upgrade + 1;
           // Debug.Log("first_upgrade: "+ first_upgrade);
            Uppoint_1.text = "+" + first_upgrade.ToString();
            
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
