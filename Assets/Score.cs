using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;

    private int score;

    // Use this for initialization
    void Start()
    {

        score = 0;
    }

    public void OnCollisionEnter(Collision collision)

    {
        string Tag = collision.gameObject.tag; //接触判定＋スコア

        if (Tag == "SmallStarTag")//ボールがオブジェクトに接触したときに
        {
            AddPoint(100);//点数を渡す。
        }
        else if
            (Tag == "LargeStarTag")
        {
            AddPoint(200);
        }
        else if
            (Tag == "SmallCloudTag")
        {
            AddPoint(300);
        }
        else if
            (Tag == "LargeCloudTag")
        {
            AddPoint(400);
        }
    }

    private void AddPoint(int point)//Addpoint関数
    {
        score = score += point;
        this.scoreText.GetComponent<Text>().text = "Score: "+score.ToString();//Score:で表示する
    }
}


   

