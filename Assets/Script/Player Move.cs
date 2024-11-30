using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.right * speed * Time.deltaTime);

        //���� ����
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //������ ����
        //Vector3 dir = Vector3.right * h + Vector3.up * v;
        Vector3 dir = new Vector3(h, v);

        //�̵�
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
