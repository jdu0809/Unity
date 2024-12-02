using System.Linq;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //���� �΋H�� ��ü�� Bullet �̰ų� Enemy��
        if (other.gameObject.name.Contains("Bullet") || other.gameObject.name.Contains("Enemy"))
        { 
                //�΋H�� ��ü ��Ȱ��ȭ
            other.gameObject.SetActive(false);

            //�΋H�� ��ü�� �Ѿ��� ��� �Ѿ� ����Ʈ�� ����(��Ȱ�� ����� �ϴϱ�)
            if (other.gameObject.name.Contains("Bullet"))
            {
                //ź���� Ŭ����(Playershoot) ������
                Playershoot player = GameObject.Find("Player").GetComponent<Playershoot>();
                //����Ʈ�� �Ѿ� ����
                player.bulletObjectPool.Add(other.gameObject);
            }
            else if (other.gameObject.name.Contains ("Enemy"))
            {
                //Enemy Ŭ���� ���ͼ� ���ӿ�����Ʈ�� ����
                GameObject emObject = GameObject.Find("EnemyManager");
                EnemyManager manager = emObject.GetComponent<EnemyManager>();

                //����Ʈ�� �Ѿ� ����
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
