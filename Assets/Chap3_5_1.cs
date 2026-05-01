using UnityEngine;

public class Chap3_5_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       for(int x =1; x < 10; x++)
        {
            for(int y=1; y < 10; y++)
            {
                Debug.Log(x*y);
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
