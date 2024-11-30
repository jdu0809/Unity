using UnityEngine;
using UnityEngine.UIElements;

public class bgpractice : MonoBehaviour
{

    public Material bgMaterial;

    public float scrollSpeed = 0.2f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgMaterial.mainTextureOffset += new Vector2(0, scrollSpeed * Time.deltaTime);
       

    }
}
