using UnityEngine;

public class Background : MonoBehaviour
{

    //���͸��� �Ӽ� ����
    public Material bgMaterial;
    public Material bgMaterial2;

    //��ũ�� �ӵ�
    public float scrollSpeed = 0.2f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //����
        Vector2 dir = Vector2.up;

        //��ũ�� : P = P0+vt   =�̷���ġ=������ġ+�ӵ�*�ð�
        bgMaterial.mainTextureOffset += dir * scrollSpeed * Time.deltaTime;

        


        if (bgMaterial2.mainTextureOffset.y < bgMaterial.mainTextureOffset.y)
        {
            
            //��������
            bgMaterial2.mainTextureOffset += dir * scrollSpeed * Time.deltaTime;
        }


    }
}
