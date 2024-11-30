using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 dir;                    //전역변수로 지정. 이유는 start함수와 update함수에서 같은 변수로 사용하기 위해서 지정. 생성되자마자 방향이 정해져야 하기 때문임.
    public float speed = 4;
    
    GameObject Player;

    //폭발공장 주소 생성
    public GameObject explosionFactory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //방향을 담을 변수 dir 선언
        //Vector3 dir;
       
        //유니티에서 랜덤하게 0부턱 9까지 가져옴
        int rnadValue = UnityEngine.Random.Range(0, 9);

        //만약에 5보다 작으면 나에게 옴
        if (rnadValue < 5)
        {
            //플레이어를 찾아 이동
            GameObject target = GameObject.Find("Player");

            //방향 추가 (enemy 입자에서 Player로)
            dir = target.transform.position - transform.position;

            //방향과 크기
            dir.Normalize();
        }
        else
        {
             dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 아래로
        //Vector3 dir = Vector3.down;
        // 움직인다(이동)
       transform.position = transform.position + dir * speed * Time.deltaTime;

        
    }
    private void OnCollisionEnter(Collision other)
    {
        //적 죽을 때 마다 ++
        ScoreManager.instance.Score++;




        //폭발효과 생성(만들기)
        GameObject explosion = Instantiate(explosionFactory);

        //폭발효과 생김  폭발효과위치 = 나(enemy)위치
        explosion.transform.position = transform.position;

        Destroy(other.gameObject);
        Destroy(gameObject);

        //잡고 스코어 증가
        //1. 씬에서 ScoreManager 찾아온다.
        GameObject smObject = GameObject.Find("ScoreManager");
        
        //2. ScoreManager 게임오브젝트에서 얻어온다.
        ScoreManager sm = smObject.GetComponent<ScoreManager>();


        //3. Get Set 함수로 수정
        sm.SetScore(sm.GetScore() + 1);
       

    }
}
