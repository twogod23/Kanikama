using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScoreScript : MonoBehaviour
{
    public Text scoretext;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        //「呼び出したいクラス名.ゲッター関数」で得点の呼び出し
        score = ScoreScript.GetScore();

        scoretext.text = string.Format("SCORE : {0}", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
