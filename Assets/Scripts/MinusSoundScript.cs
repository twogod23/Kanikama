using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusSoundScript : MonoBehaviour
{
    //サウンドを割り当てる関数を定義
    //インスペクター画面内のスクリプトのコンポーネントにサウンドを設定する！
    public AudioClip minussound;
    AudioSource audioSourse;

    // Start is called before the first frame update
    void Start()
    {
        //オーディオコンポーネントを取得
        audioSourse = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetMinus()
    {
        //サウンドを鳴らす
        audioSourse.PlayOneShot(minussound);
    }
}
