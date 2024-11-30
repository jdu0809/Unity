using UnityEngine;

public class Playershoot : MonoBehaviour
{
    //총알 묶음(탄창-K2)
    //총알 발사 버튼 클릭(Fire1)

    public GameObject k2;
    public GameObject fireposition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        //총알 발사 2
        //총알이 탄창에 채워지기 3
        //발사 버튼 클릭 1

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(k2) ;

            bullet.transform.position = fireposition.transform.position;
        }
    }
}
