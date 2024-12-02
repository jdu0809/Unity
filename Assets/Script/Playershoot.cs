using JetBrains.Annotations;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playershoot : MonoBehaviour
{
    //�Ѿ� ����(źâ-K2)
    //�Ѿ� �߻� ��ư Ŭ��(Fire1)

    public GameObject k2;
    public GameObject fireposition;

    //źâ �Ѿ� ����
    public int poolSize = 10;
    //������Ʈ Ǯ �迭
    public List<GameObject> bulletObjectPool;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
        //1. �¾� �� �� �Ѿ��� �ѹ� ���� �Ǿ� �־�� �ϴϱ� Start�Լ����� ����
    {
        //�ȵ���̵� ����� ��
        #if UNITY_ANDROID
            GameObject.Find("Joystick canvas XYBZ").SetActive(true);
        #elif UNITY_EDITOR || UNITY_STANDALONE
            GameObject.Find("Joystick canvas XYBZ").SetActive(false);
        #endif



        //2. źâ�� ���� �Ѿ� ����
        bulletObjectPool = new List<GameObject>();

        //3. źâ ������ŭ �ݺ�    //#for �� ��Ģ     for (����; ����; ����) {}  �� ����Ǿ����� ������ ������ ������ �� ���� ����
        for (int i = 0; i< poolSize; i++)
        {
            //4. �Ѿ˻���
            GameObject bullet = Instantiate(k2);
            //5. źâ ä���(������Ʈ Ǯ)
            bulletObjectPool.Add(bullet);
            //��Ȱ��ȭ
            bullet.SetActive(false);
        }
    }

    // Update is called once per frame

    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE

        //1. �߻� ��ư ������
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();




        }
    }
#endif
        public void Fire() 
        {

        ////////����Ʈ�� �ٲ� ��////////////////
        //źâ�� �Ѿ��� ������
        if (bulletObjectPool.Count > 0)

        {

            //��Ȱ��ȭ�� �Ѿ��� �ϳ� �����´�
            GameObject bullet = bulletObjectPool[0];
            //�Ѿ��� �߻�(Ȱ��ȭ)
            bullet.SetActive(true);
            //�߻������ϱ� ������Ʈ Ǯ���� �Ѿ�����
            bulletObjectPool.Remove(bullet);

            //�Ѿ� ��ġ
            bullet.transform.position = transform.position;

        }

        //////////////////////�迭 �������� ����/////////////////////////////
        //2. źâ�ȿ� �ִ� �Ѿ˵� �߿�
        //for (int i = 0; i < poolSize; i++)
        //{

        //3. ��Ȱ��ȭ�� �Ѿ�
        //���� �Ѿ��� ��Ȱ��ȭ �Ǿ��ٸ�
        //GameObject bullet = bulletObjectPool[i];
        //if (bullet.activeSelf == false)
        //{

        //4. �Ѿ˹߻�(Start���� ��Ȱ��ȭ �س����� �ٽ� Ȱ��ȭ)
        //bullet.SetActive(true);
        //5. �Ѿ� ��ġ
        //bullet.transform.position = transform.position;

        //�߻� �����ϱ� if�� �˻� ����
        //break;



        //}

    }
        }
    

