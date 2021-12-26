using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusScript : MonoBehaviour
{
    //���_���Ǘ������̃Q�[���I�u�W�F�N�g���`
    GameObject director1;

    //�T�E���h���Ǘ�����Q�[���I�u�W�F�N�g�̒�`
    GameObject director2;

    // Start is called before the first frame update
    void Start()
    {
        //���_�Ǘ��̃Q�[���I�u�W�F�N�g��F�m������
        director1 = GameObject.Find("GameDirector");

        //�T�E���h�Ǘ��̃Q�[���I�u�W�F�N�g�̎w��
        director2 = GameObject.Find("MinusSound");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�����蔻��
    void OnTriggerEnter2D(Collider2D other)
    {
        //���_���Ǘ�����v���O�����Ƀf�[�^�𑗐M
        director1.GetComponent<ScoreScript>().GetMinus();

        //�T�E���h���Ǘ�����v���O�����Ƀf�[�^�𑗐M
        director2.GetComponent<MinusSoundScript>().GetMinus();

        //�}�C�i�X�u���b�N������
        Destroy(gameObject);

        Debug.Log("Minus");
    }
}
