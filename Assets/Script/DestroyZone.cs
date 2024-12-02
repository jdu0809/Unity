using System.Linq;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //만약 부딫힌 물체가 Bullet 이거나 Enemy면
        if (other.gameObject.name.Contains("Bullet") || other.gameObject.name.Contains("Enemy"))
        { 
                //부딫힌 물체 비활성화
            other.gameObject.SetActive(false);

            //부딫힌 물체가 총알일 경우 총알 리스트에 삽입(재활용 해줘야 하니까)
            if (other.gameObject.name.Contains("Bullet"))
            {
                //탄알집 클래스(Playershoot) 얻어오기
                Playershoot player = GameObject.Find("Player").GetComponent<Playershoot>();
                //리스트에 총알 삽입
                player.bulletObjectPool.Add(other.gameObject);
            }
            else if (other.gameObject.name.Contains ("Enemy"))
            {
                //Enemy 클래스 얻어와서 게임오브젝트로 지정
                GameObject emObject = GameObject.Find("EnemyManager");
                EnemyManager manager = emObject.GetComponent<EnemyManager>();

                //리스트에 총알 삽입
                manager.enemyObjectPool.Add(other.gameObject);
            }
        }

        Destroy(other.gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
