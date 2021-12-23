using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScript : MonoBehaviour
{
    //距離を測る2物体の指定
    GameObject player;
    GameObject goal;
    GameObject distancetext;

    // Start is called before the first frame update
    void Start()
    {
        //得点を表示するテキストのゲームオブジェクトを指定
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
            //得点を表示するテキストのゲームオブジェクトのコンポーネントを指定して、表示するテキストを指定
            this.distancetext.GetComponent<Text>().text = "";
        }
    }
}
