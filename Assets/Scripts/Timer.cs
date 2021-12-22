using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //制限時間の指定
    public float countdown = 200.0f;

    //時間表示のテキスト変数の指定
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //カウントダウンをさせる
        countdown -= Time.deltaTime;

        //
    }
}
