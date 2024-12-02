using JetBrains.Annotations;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playershoot : MonoBehaviour
{
    //총알 묶음(탄창-K2)
    //총알 발사 버튼 클릭(Fire1)

    public GameObject k2;
    public GameObject fireposition;

    //탄창 총알 개수
    public int poolSize = 10;
    //오브젝트 풀 배열
    public List<GameObject> bulletObjectPool;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
        //1. 태어 날 때 총알이 한발 장전 되어 있어야 하니까 Start함수에서 시작
    {
        //안드로이드 모바일 용
        #if UNITY_ANDROID
            GameObject.Find("Joystick canvas XYBZ").SetActive(true);
        #elif UNITY_EDITOR || UNITY_STANDALONE
            GameObject.Find("Joystick canvas XYBZ").SetActive(false);
        #endif



        //2. 탄창을 담을 총알 개수
        bulletObjectPool = new List<GameObject>();

        //3. 탄창 개수만큼 반복    //#for 문 규칙     for (변수; 조건; 실행) {}  로 진행되어지며 변수가 조건을 만족할 때 까지 실행
        for (int i = 0; i< poolSize; i++)
        {
            //4. 총알생성
            GameObject bullet = Instantiate(k2);
            //5. 탄창 채우기(오브젝트 풀)
            bulletObjectPool.Add(bullet);
            //비활성화
            bullet.SetActive(false);
        }
    }

    // Update is called once per frame

    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE

        //1. 발사 버튼 누르면
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();




        }
    }
#endif
        public void Fire() 
        {

        ////////리스트로 바꾼 것////////////////
        //탄창에 총알이 있으면
        if (bulletObjectPool.Count > 0)

        {

            //비활성화된 총알을 하나 가져온다
            GameObject bullet = bulletObjectPool[0];
            //총알을 발사(활성화)
            bullet.SetActive(true);
            //발사했으니까 오브젝트 풀에서 총알제거
            bulletObjectPool.Remove(bullet);

            //총알 위치
            bullet.transform.position = transform.position;

        }

        //////////////////////배열 구조에서 쓴것/////////////////////////////
        //2. 탄창안에 있는 총알들 중에
        //for (int i = 0; i < poolSize; i++)
        //{

        //3. 비활성화된 총알
        //만약 총알이 비활성화 되었다면
        //GameObject bullet = bulletObjectPool[i];
        //if (bullet.activeSelf == false)
        //{

        //4. 총알발사(Start에서 비활성화 해놓은것 다시 활성화)
        //bullet.SetActive(true);
        //5. 총알 위치
        //bullet.transform.position = transform.position;

        //발사 했으니까 if문 검색 종료
        //break;



        //}

    }
        }
    

