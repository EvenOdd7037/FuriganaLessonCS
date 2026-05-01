using UnityEngine;

public class Chap3_3_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int cnt = 0; cnt < 5; cnt++)
        {
            Debug.Log("Hello!");
            Debug.Log(cnt+1 +"回目のHelloでした");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
