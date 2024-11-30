using UnityEngine;

public class Background : MonoBehaviour
{

    //머터리얼 속성 지정
    public Material bgMaterial;
    public Material bgMaterial2;

    //스크롤 속도
    public float scrollSpeed = 0.2f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //방향
        Vector2 dir = Vector2.up;

        //스크롤 : P = P0+vt   =미래위치=현재위치+속도*시간
        bgMaterial.mainTextureOffset += dir * scrollSpeed * Time.deltaTime;

        


        if (bgMaterial2.mainTextureOffset.y < bgMaterial.mainTextureOffset.y)
        {
            
            //수정사항
            bgMaterial2.mainTextureOffset += dir * scrollSpeed * Time.deltaTime;
        }


    }
}
