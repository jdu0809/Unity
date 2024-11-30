using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 dir;                    //���������� ����. ������ start�Լ��� update�Լ����� ���� ������ ����ϱ� ���ؼ� ����. �������ڸ��� ������ �������� �ϱ� ������.
    public float speed = 4;
    
    GameObject Player;

    //���߰��� �ּ� ����
    public GameObject explosionFactory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� ���� dir ����
        //Vector3 dir;
       
        //����Ƽ���� �����ϰ� 0���� 9���� ������
        int rnadValue = UnityEngine.Random.Range(0, 9);

        //���࿡ 5���� ������ ������ ��
        if (rnadValue < 5)
        {
            //�÷��̾ ã�� �̵�
            GameObject target = GameObject.Find("Player");

            //���� �߰� (enemy ���ڿ��� Player��)
            dir = target.transform.position - transform.position;

            //����� ũ��
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
        // �Ʒ���
        //Vector3 dir = Vector3.down;
        // �����δ�(�̵�)
       transform.position = transform.position + dir * speed * Time.deltaTime;

        
    }
    private void OnCollisionEnter(Collision other)
    {
        //�� ���� �� ���� ++
        ScoreManager.instance.Score++;




        //����ȿ�� ����(�����)
        GameObject explosion = Instantiate(explosionFactory);

        //����ȿ�� ����  ����ȿ����ġ = ��(enemy)��ġ
        explosion.transform.position = transform.position;

        Destroy(other.gameObject);
        Destroy(gameObject);

        //��� ���ھ� ����
        //1. ������ ScoreManager ã�ƿ´�.
        GameObject smObject = GameObject.Find("ScoreManager");
        
        //2. ScoreManager ���ӿ�����Ʈ���� ���´�.
        ScoreManager sm = smObject.GetComponent<ScoreManager>();


        //3. Get Set �Լ��� ����
        sm.SetScore(sm.GetScore() + 1);
       

    }
}
