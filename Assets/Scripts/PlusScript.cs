using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusScript : MonoBehaviour
{

    //得点を管理する空のゲームオブジェクトを定義
    GameObject director;

    // Start is called before the first frame update
    void Start()
    {
        //得点管理のゲームオブジェクトを認知させる
        this.director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //当たり判定
    void OnTriggerEnter2D(Collider2D collider)
    {
        //得点を管理するプログラムにデータを送信
        this.director.GetComponent<ScoreScript>().GetPlus();
        Debug.Log("Plus");

        Destroy(gameObject);
    }
}
