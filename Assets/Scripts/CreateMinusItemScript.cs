using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMinusItemScript : MonoBehaviour
{
    //��������v���n�u�̊i�[
    public GameObject PrefabItem;

    int ItemNum;

    // Start is called before the first frame update
    void Start()
    {
        for (ItemNum = 1; ItemNum <= 100; ItemNum++)
        {
            //�v���n�u�̈ʒu�������_���Ŏw��
            float x = Random.Range(9.0f, 2090.0f);
            float y = Random.Range(-2.9f, 3.0f);
            Vector3 pos = new Vector3(x, y, 1.0f);

            //�v���n�u�𐶐�
            Instantiate(PrefabItem, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
