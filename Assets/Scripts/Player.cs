using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    //距離を測る2物体の指定
    GameObject player;
    GameObject goal;
    GameObject distancetext;

    // Start is called before the first frame update
    void Start()
    {
        //距離の基準となるゲームオブジェクトを指定
        distancetext = GameObject.Find("DistanceText");
        player = GameObject.Find("Player");
        goal = GameObject.Find("Goal");
    }

    // Update is called once per frame
    void Update()
    {
        float posA = player.transform.position.x;
        float posB = goal.transform.position.x;
        float dist = posB - posA;

        if (dist < 500)
        {
            transform.Translate(0.06f, 0, 0);
        } 
        else if (dist < 1000)
        {
            transform.Translate(0.05f, 0, 0);
        } 
        else if (dist < 1300)
        {
            transform.Translate(0.04f, 0, 0);
        } 
        else if (dist < 1600)
        {
            transform.Translate(0.04f, 0, 0);
        } 
        else if (dist < 1900)
        {
            transform.Translate(0.03f, 0, 0);
        } 
        else
        {
            transform.Translate(0.02f, 0, 0);
        }
    }
}
