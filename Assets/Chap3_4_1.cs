using UnityEngine;

public class Chap3_4_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int cnt =5; cnt >=0; cnt=cnt-2)
        {
            Debug.Log(cnt +"回目のハローかもね。");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
