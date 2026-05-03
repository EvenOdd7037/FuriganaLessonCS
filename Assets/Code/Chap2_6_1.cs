using UnityEngine;

public class Chap2_6_1 : MonoBehaviour
{
    public int age;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(age < 20)
        {
            Debug.Log("未成年");
        }else if(age < 65)
        {
            Debug.Log("成人");
        }else
        {
            Debug.Log("高齢者");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
