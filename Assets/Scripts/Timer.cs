using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //�������Ԃ̎w��
    public float countdown = 200.0f;

    //���ԕ\���̃e�L�X�g�ϐ��̎w��
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�J�E���g�_�E����������
        countdown -= Time.deltaTime;

        //
    }
}
