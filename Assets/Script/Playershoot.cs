using UnityEngine;

public class Playershoot : MonoBehaviour
{
    //�Ѿ� ����(źâ-K2)
    //�Ѿ� �߻� ��ư Ŭ��(Fire1)

    public GameObject k2;
    public GameObject fireposition;

    //źâ �Ѿ� ����
    public int poolSize = 10;
    //������Ʈ Ǯ �迭
    GameObject[] bulletObjectPool;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //1. �¾� �� �� �Ѿ��� �ѹ� ���� �Ǿ� �־�� �ϴϱ� Start�Լ����� ����
    {
        //2. źâ�� ���� �Ѿ� ����
        bulletObjectPool = new GameObject[poolSize];

        //3. źâ ������ŭ �ݺ�    //#for �� ��Ģ     for (����; ����; ����) {}  �� ����Ǿ����� ������ ������ ������ �� ���� ����
        for (int i = 0; i< poolSize; i++)
        {
            //4. �Ѿ˻���
            GameObject bullet = Instantiate(k2);
            //5. źâ ä���(������Ʈ Ǯ)
            bulletObjectPool[i] = bullet;
            //��Ȱ��ȭ
            bullet.SetActive(false);
        }
    }

    // Update is called once per frame

    void Update()
    {
        //1. �߻� ��ư ������
        if (Input.GetButtonDown("Fire1"))
        {

            //2. źâ�ȿ� �ִ� �Ѿ˵� �߿�
            for (int i = 0; i < poolSize; i++)
            {

                //3. ��Ȱ��ȭ�� �Ѿ�
                //���� �Ѿ��� ��Ȱ��ȭ �Ǿ��ٸ�
                GameObject bullet = bulletObjectPool[i];
                if (bullet.activeSelf == false)
                {

                    //4. �Ѿ˹߻�(Start���� ��Ȱ��ȭ �س����� �ٽ� Ȱ��ȭ)
                    bullet.SetActive(true);
                    //5. �Ѿ� ��ġ
                    bullet.transform.position = transform.position;

                    //�߻� �����ϱ� if�� �˻� ����
                    break;



                }

            }
        }
    }
}
