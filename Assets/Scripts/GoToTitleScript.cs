using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToTitleScript : MonoBehaviour
{
    //�{�^���������ꂽ�Ƃ��ɌĂяo�����֐�
    public void Select()
    {
        //�s���鑀�� ���C�����j���[��ʂֈړ�
        SceneManager.LoadScene("TitleScene");
    }
}