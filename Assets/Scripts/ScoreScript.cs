using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    GameObject scoreText;
    int score = 0;

    public void GetPlus()
    {
        this.score += 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        //得点を表示するテキストを指定
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = "得点 " + this.score.ToString();
    }
}
