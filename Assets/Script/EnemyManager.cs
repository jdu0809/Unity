using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    //Ǯ ũ��, Ǯ �迭, SpawnPoints
    public int poolSize = 10;
    GameObject[] enemyObjectPool;
    public Transform[] SpawnPoints;
    


    //�ּҽð� �� �ִ�ð� �Ҵ�
    float minTime = 1;
    float maxTime = 5;

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
        enemyObjectPool = new GameObject[poolSize];

        //������Ʈ Ǯ�� ���� ���ʹ� ������ŭ �ݺ� �Ͽ�
        for (int i = 0; i < poolSize; i++)
        {

            //���ʹ̰��忡�� ���ʹ� ����
            GameObject enemy = Instantiate(enemyfactory);
            //���ʹ� Ǯ�� �ְ� �ʹ�
            enemyObjectPool[i] = enemy;

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
            for (int i = 0; i < poolSize; i++)
            { 
                //��Ȱ��ȭ �� ���ʹ̸�

                //���࿡ ���ʹ̰� ��Ȱ�̸�
                GameObject enemy = enemyObjectPool[i];
                if (enemy.activeSelf == false)
                {
                    //���ʹ� ��ġ ��Ű��
                    enemy.transform.position = transform.position;
                    //Ȱ��ȭ ���ְ�
                    enemy.SetActive(true);

                    break;
                }
                


            }

            
            

            //������ �ð� �ʱ�ȭ
            currentTime = 0;

            createTime = UnityEngine.Random .Range(minTime, maxTime);
        }
    }
}
