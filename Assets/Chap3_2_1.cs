using JetBrains.Annotations;
using UnityEngine;

public class Chap3_2_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int shikin = 30000;
        while(shikin >= 0)
        {
            Debug.Log(shikin);
            shikin = shikin - 5080;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
