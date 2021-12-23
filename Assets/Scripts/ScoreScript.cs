using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    GameObject scoreText;
    //���_�𑼂̃V�[���ŋ��L���邽�߁A�upublic static�v�Ő錾
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
        //���_��\������e�L�X�g�̃Q�[���I�u�W�F�N�g���w��
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
            //���_��\������e�L�X�g�̃Q�[���I�u�W�F�N�g�̃R���|�[�l���g���w�肵�āA�\������e�L�X�g���w��
            this.scoreText.GetComponent<Text>().text = "Score " + score.ToString();
        }
    }

    public static int GetScore()
    {
        return score;
    }    
}
