using UnityEngine;

public class EnemyManager : MonoBehaviour
{

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
    }

    // Update is called once per frame
    void Update()
    {
        //시간흐르다가
        currentTime += Time.deltaTime;
        //일정 시간 설정
        if (currentTime > createTime)
        {
            //적생성해서
            GameObject enemy = Instantiate(enemyfactory);
            //나에게 따라오게
            enemy.transform.position = transform.position;

            //생성후 시간 초기화
            currentTime = 0;

            createTime = UnityEngine.Random .Range(minTime, maxTime);
        }
    }
}
