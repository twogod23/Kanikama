using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScript : MonoBehaviour
{
    //�����𑪂�2���̂̎w��
    GameObject player;
    GameObject goal;
    GameObject distancetext;

    // Start is called before the first frame update
    void Start()
    {
        //���_��\������e�L�X�g�̃Q�[���I�u�W�F�N�g���w��
        this.distancetext = GameObject.Find("DistanceText");
        this.player = GameObject.Find("Player");
        this.goal = GameObject.Find("Goal");
    }

    // Update is called once per frame
    void Update()
    {
        float posA = this.player.transform.position.x;
        float posB = this.goal.transform.position.x;
        float dist = posB - posA;

        if (dist >= 0)
        {
            this.distancetext.GetComponent<Text>().text = "Distance " + dist.ToString() + "m";
        }
        else
        {
            //���_��\������e�L�X�g�̃Q�[���I�u�W�F�N�g�̃R���|�[�l���g���w�肵�āA�\������e�L�X�g���w��
            this.distancetext.GetComponent<Text>().text = "";
        }
    }
}
