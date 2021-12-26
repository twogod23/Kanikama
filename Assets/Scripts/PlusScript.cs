using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusScript : MonoBehaviour
{

    //得点を管理する空のゲームオブジェクトを定義
    GameObject director1;

    //サウンドを管理するゲームオブジェクトの定義
    GameObject director2;

    // Start is called before the first frame update
    void Start()
    {
        //得点管理のゲームオブジェクトを認知させる
        director1 = GameObject.Find("GameDirector");

        //サウンド管理のゲームオブジェクトの指定
        director2 = GameObject.Find("PlusSound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //当たり判定
    void OnTriggerEnter2D(Collider2D collider)
    {
        //得点を管理するプログラムにデータを送信
        director1.GetComponent<ScoreScript>().GetPlus();

        //サウンドを管理するプログラムにデータを送信
        director2.GetComponent<PlusSoundScript>().GetPlus();

        Debug.Log("Plus");

        //プラスブロックを消去
        Destroy(gameObject);
    }
}
