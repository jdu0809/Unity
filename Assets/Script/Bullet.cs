using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.localPosition + Vector3.up * speed * Time.deltaTime;
    }
}
