using UnityEngine;

public class Playershoot : MonoBehaviour
{
    //�Ѿ� ����(źâ-K2)
    //�Ѿ� �߻� ��ư Ŭ��(Fire1)

    public GameObject k2;
    public GameObject fireposition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        //�Ѿ� �߻� 2
        //�Ѿ��� źâ�� ä������ 3
        //�߻� ��ư Ŭ�� 1

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(k2) ;

            bullet.transform.position = fireposition.transform.position;
        }
    }
}
