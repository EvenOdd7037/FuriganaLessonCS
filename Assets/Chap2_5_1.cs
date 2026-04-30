using UnityEngine;

public class Chap2_5_1 : MonoBehaviour
{
    public int age;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(age < 20)
        {
            Debug.Log("未成年");
        }
        else
        {
            Debug.Log("成人");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
