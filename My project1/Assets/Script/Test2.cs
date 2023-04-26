using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test2 : MonoBehaviour
{
    public int hp = 180;
    public Text textHpUI;                   // HP UI ǥ�ü���
    public Text textstateUI;                // state ǥ�� ����
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        //--------------------------------------------------------
        // UI ����
        //--------------------------------------------------------
        textHpUI.text = hp.ToString();      // HP ���ڿ��� ����


        if (hp <= 50)
        {
            textstateUI.text = "RUN!";
        }
        else if (hp >= 200)
        {
            textstateUI.text = "Attack!";
        }
        else
        {
            textstateUI.text = "Defance!";
        }

        //--------------------------------------------------------
        // Input ����
        //--------------------------------------------------------

        if (Input.GetMouseButtonDown(0))    // ���콺 ���� ��ư
        {
            hp += 10;
        }
        if (Input.GetMouseButtonDown(1))    // ���콺 ������ ��ư
        {
            hp -= 10;
        }
    }
}
