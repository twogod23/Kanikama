using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinusScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�����蔻��
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("GameOverScene");

        Debug.Log("Minus");
    }
}
