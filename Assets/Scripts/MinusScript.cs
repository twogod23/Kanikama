using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusScript : MonoBehaviour
{
    //���_���Ǘ������̃Q�[���I�u�W�F�N�g���`
    GameObject director;

    // Start is called before the first frame update
    void Start()
    {
        //���_�Ǘ��̃Q�[���I�u�W�F�N�g��F�m������
        this.director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�����蔻��
    void OnTriggerEnter2D(Collider2D other)
    {
        //���_���Ǘ�����v���O�����Ƀf�[�^�𑗐M
        this.director.GetComponent<ScoreScript>().GetMinus();

        Destroy(gameObject);

        Debug.Log("Minus");
    }
}
