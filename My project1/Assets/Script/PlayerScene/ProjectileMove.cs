using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public enum PROJECTILETYPE                                                                                //enum으로 타입 선언
    {
        PLAYER,
        MONSTER
    }
    public Vector3 launchDirection;                                                                            //발사방향

    public PROJECTILETYPE projectileType;

    private void FixedUpdate()
    {
        float moveAmout = 10 * Time.fixedDeltaTime;                                                            //이동 속도 설정
        transform.Translate(launchDirection * moveAmout);                                                      //Translate로 이동
    }

    //private void OnCollisionEnter(Collision collision)          //충돌이 일어났을 경우
    //{
    //    Debug.Log(collision.gameObject.name);
    //    if(collision.gameObject.tag == "Object")                //Tag 값이 오브젝트인 경우
    //    {
    //        Destroy(this.gameObject);
    //    }

    //    if (collision.gameObject.tag == "Monster")                //Tag 값이 오브젝트인 경우
    //    {
    //        Destroy(this.gameObject);
    //        collision.gameObject.GetComponent<Monster>().Damaged(1);
    //    }
    //}

    private void OnTriggerEnter(Collider other)                                                                //트리거 예약 함수
    {
        if (other.CompareTag("Monster") && projectileType == PROJECTILETYPE.PLAYER)                            //Tag를 검사
        {
            Destroy(this.gameObject);
            other.gameObject.GetComponent<Monster>().Damaged(1);
            GameObject Temp = GameObject.FindGameObjectWithTag("GameManager");
            Temp.GetComponent<HUDTextManager>().UpdateHUDTextSet("1", other.gameObject, new Vector3(0.0f, 10.0f));
        }

        if (other.CompareTag("Player") && projectileType == PROJECTILETYPE.MONSTER)                            //Tag를 검사
        {
            Destroy(this.gameObject);
            other.gameObject.GetComponent<PlayerHp>().Damaged(1);
            GameObject Temp = GameObject.FindGameObjectWithTag("GameManager");
            Temp.GetComponent<HUDTextManager>().UpdateHUDTextSet("1", other.gameObject, new Vector3(0.0f, 10.0f));
        }
    }

}


//Projectilemove