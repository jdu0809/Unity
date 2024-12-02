using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    //Ǯ ũ��, Ǯ �迭, SpawnPoints
    public int poolSize = 10;
    public List<GameObject> enemyObjectPool;
    public Transform[] spawnPoints;
    


    //�ּҽð� �� �ִ�ð� �Ҵ�
    public float minTime = 0.5f;
    public float maxTime = 1.5f;

    //����ð�
    float currentTime;
    //�����ð��� ������
    public float createTime = 1;
    //���忡�� �� ����
    public GameObject enemyfactory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            
        createTime = UnityEngine.Random.Range(minTime, maxTime);


        //������Ʈ�� Ǯ�� ���ʹ̵��� ���� �� �ִ� ũ��� ������ش�.
        enemyObjectPool = new List<GameObject>();

        //������Ʈ Ǯ�� ���� ���ʹ� ������ŭ �ݺ� �Ͽ�
        for (int i = 0; i < poolSize; i++)
        {

            //���ʹ̰��忡�� ���ʹ� ����
            GameObject enemy = Instantiate(enemyfactory);
            //���ʹ� Ǯ�� �ְ� �ʹ�
            enemyObjectPool.Add(enemy);

            //��Ȱ��ȭ
            enemy.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {
       
       
        //�ð��帣�ٰ�
        currentTime += Time.deltaTime;
        //���� �ð� ����
        if (currentTime > createTime)
        {

            //������ Ǯ�������ʹ� �߿�
            
            
                //��Ȱ��ȭ �� ���ʹ̸�

                //���࿡ ������Ʈ Ǯ �ȿ� ���ʹ̰� ������
                
                if (enemyObjectPool.Count > 0)
                {
                   
                //������Ʈ Ǯ���� enemy�� ������ ����ϵ��� ��.
                GameObject enemy = enemyObjectPool[0];
                //������ƮǮ���� ���ʹ� ����
                enemyObjectPool.Remove(enemy);

                    //�������� �ε��� ����
                int index = Random.Range(0, spawnPoints.Length);
                    //���ʹ� ��ġ ��Ű��
                    enemy.transform.position = spawnPoints[index].position;

                    //Ȱ��ȭ ���ְ�
                    enemy.SetActive(true);

                    //break;
                }

               


            
            
            

            //������ �ð� �ʱ�ȭ
            currentTime = 0;

            createTime = UnityEngine.Random .Range(minTime, maxTime);
        }
    }
}
