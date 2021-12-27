using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float jump = 500f;
    public float jc;

    //サウンドを割り当てる関数を定義
    //インスペクター画面内のスクリプトのコンポーネントにサウンドを設定する！
    public AudioClip jumpsound;
    AudioSource audioSourse;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        jc = 0;

        //オーディオコンポーネントを取得
        audioSourse = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
            if(jc == 0)
            {
                rb2d.AddForce(Vector2.up * jump);
                jc = 1;
                //サウンドを鳴らす
                audioSourse.PlayOneShot(jumpsound);
            }else if(jc == 1)
            {
                rb2d.AddForce(Vector2.up * jump);
                jc = 2;
                //サウンドを鳴らす
                audioSourse.PlayOneShot(jumpsound);
            }
            else
            {

            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jc = 0;
        }
    }
}
