using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataControl : MonoBehaviour
{
    /*    public GameObject score;*/
/*    public Score score;*/

    public int success_rate = 75;
    public int success_count = 0;
    public int upgrade_chance = 10;
    public int fail_count = 0;
    //public bool isover = false;
    public GameObject Result;

    public void IfSuccess()
    {
        success_rate = success_rate - 10;
        success_count = success_count + 1;
    }
    public void NoSuccess()
    {
        success_rate = success_rate + 10;
        success_count = 0;
        fail_count = fail_count + 1;
    }
    public void DoUpgrade()
    {
        upgrade_chance = upgrade_chance - 1;
        Debug.Log(upgrade_chance);
        if (upgrade_chance == 0)
        {
            gameover();
            
        }
    }
    public void gameover()
    {
        Invoke("NextScene", 0.5f);
/*        score.scoreUpdate();*/
    }

    void NextScene()
    {
        Result.SetActive(true);
    }
}
