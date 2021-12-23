using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    GameObject scoreText;
    //得点を他のシーンで共有するため、「public static」で宣言
    public static int score = 0;

    public void GetPlus()
    {
        score += 1;
    }

    public void GetMinus()
    {
        score -= 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        //得点を表示するテキストのゲームオブジェクトを指定
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        if(score < 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
        else
        {
            //得点を表示するテキストのゲームオブジェクトのコンポーネントを指定して、表示するテキストを指定
            this.scoreText.GetComponent<Text>().text = "Score " + score.ToString();
        }
    }

    public static int GetScore()
    {
        return score;
    }    
}
