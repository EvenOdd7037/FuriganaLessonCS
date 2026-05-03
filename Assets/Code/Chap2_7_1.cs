using UnityEngine;

public class Chap2_7_1 : MonoBehaviour
{
    public int age;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(age>=6 && age <= 15)
        {
            Debug.Log("あなたは義務教育年齢ですね。");
        }
        if(age<=15 || 65<= age)
        {
            Debug.Log("統計的には生産年齢ではなさげですね。");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
