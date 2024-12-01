using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    //풀 크기, 풀 배열, SpawnPoints
    public int poolSize = 10;
    GameObject[] enemyObjectPool;
    public Transform[] SpawnPoints;
    


    //최소시간 및 최대시간 할당
    float minTime = 1;
    float maxTime = 5;

    //현재시간
    float currentTime;
    //일정시간이 지나면
    public float createTime = 1;
    //공장에서 적 생성
    public GameObject enemyfactory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            
        createTime = UnityEngine.Random.Range(minTime, maxTime);


        //오브젝트를 풀을 에너미들을 담을 수 있는 크기로 만들어준다.
        enemyObjectPool = new GameObject[poolSize];

        //오브젝트 풀에 넣을 에너미 개수만큼 반복 하여
        for (int i = 0; i < poolSize; i++)
        {

            //에너미공장에서 에너미 생성
            GameObject enemy = Instantiate(enemyfactory);
            //에너미 풀에 넣고 싶다
            enemyObjectPool[i] = enemy;

            //비활성화
            enemy.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {
       
       
        //시간흐르다가
        currentTime += Time.deltaTime;
        //일정 시간 설정
        if (currentTime > createTime)
        {

            //에너지 풀에서에너미 중에
            for (int i = 0; i < poolSize; i++)
            { 
                //비활성화 된 에너미를

                //만약에 에너미가 비활이면
                GameObject enemy = enemyObjectPool[i];
                if (enemy.activeSelf == false)
                {
                    //에너미 위치 시키고
                    enemy.transform.position = transform.position;
                    //활성화 해주고
                    enemy.SetActive(true);

                    break;
                }
                


            }

            
            

            //생성후 시간 초기화
            currentTime = 0;

            createTime = UnityEngine.Random .Range(minTime, maxTime);
        }
    }
}
