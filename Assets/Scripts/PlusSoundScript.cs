using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusSoundScript : MonoBehaviour
{
    //サウンドを割り当てる関数を定義
    //インスペクター画面内のスクリプトのコンポーネントにサウンドを設定する！
    public AudioClip plussound;
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

    public void GetPlus()
    {
        //サウンドを鳴らす
        audioSourse.PlayOneShot(plussound);
    }
}
