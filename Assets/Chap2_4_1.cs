using UnityEngine;

public class Chap2_4_1 : MonoBehaviour
{
    public int age;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(age < 20)
        {
            Debug.Log(age + "歳は\nその…");
            Debug.Log("未成年");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
