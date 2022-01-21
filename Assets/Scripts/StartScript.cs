using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    //サウンドを割り当てる関数を定義
    //インスペクター画面内のスクリプトのコンポーネントにサウンドを設定する！
    public AudioClip startsound;
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
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("MainScene");

            //サウンドを鳴らす
            audioSourse.PlayOneShot(startsound);
        }
    }
}
