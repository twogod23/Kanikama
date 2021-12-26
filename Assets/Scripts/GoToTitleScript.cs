using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToTitleScript : MonoBehaviour
{
    //ボタンが押されたときに呼び出される関数
    public void Select()
    {
        //ボタンが押されたときに呼び出される関数
        SceneManager.LoadScene("TitleScene");
    }
}