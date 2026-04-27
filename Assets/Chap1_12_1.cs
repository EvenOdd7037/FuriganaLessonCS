using UnityEngine;

public class Chap1_12_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int value = Mathf.Max(10, 40 , 20, 30);
        Debug.Log(value);
        float root = Mathf.Sqrt(2);
        double rootf =Mathf.Sqrt(2);
        Debug.Log(root);
        Debug.Log(rootf);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
