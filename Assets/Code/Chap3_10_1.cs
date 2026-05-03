using UnityEngine;

public class Chap3_10_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] grade = {"松","竹","梅"};
        foreach(string g in grade)
        {
            Debug.Log(g);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
