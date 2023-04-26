using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                                                                         //UI���

public class HUDTextManager : MonoBehaviour
{

    public Text hudText;
    public GameObject character;                                                              //ĳ���� ���� ������Ʈ�� ����
    public Vector3 offset;                                                                    //ĳ���� �Ӹ� ���� �ؽ�Ʈ�� ǥ���� ������

    public GameObject HudTextUp;                                                              //�ö󰡴� �ؽ�Ʈ ������
    public GameObject canvasObject;                                                           //Canvas Transform ��ǥ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ĳ���� �Ӹ� ���� �ؽ�Ʈ ǥ��
        Vector3 characterHeadPosition = character.transform.position;
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(characterHeadPosition);         //3D Position > 2D
        hudText.transform.position = screenPosition + offset;
        
    }

    public void UpdateHUDTextSet(string newText, GameObject target, Vector3 TargetOffset)
    {
        Vector3 TargetPosition = target.transform.position;
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(TargetPosition);                 //3D Position > 2D
        GameObject temp = (GameObject)Instantiate(HudTextUp);
        temp.transform.SetParent(canvasObject.transform, false);
        temp.transform.position = screenPosition + TargetOffset;
        //HUDMove Class

    }
}
