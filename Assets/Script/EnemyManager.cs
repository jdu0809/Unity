using UnityEngine;

public class EnemyManager : MonoBehaviour
{

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
    }

    // Update is called once per frame
    void Update()
    {
        //�ð��帣�ٰ�
        currentTime += Time.deltaTime;
        //���� �ð� ����
        if (currentTime > createTime)
        {
            //�������ؼ�
            GameObject enemy = Instantiate(enemyfactory);
            //������ �������
            enemy.transform.position = transform.position;

            //������ �ð� �ʱ�ȭ
            currentTime = 0;

            createTime = UnityEngine.Random .Range(minTime, maxTime);
        }
    }
}
