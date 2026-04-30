using UnityEngine;

public class Chap2_7_3 : MonoBehaviour
{
    public int number;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (! Mathf.IsPowerOfTwo(number))
        {
            Debug.Log("それは２のx乗じゃないぜ！\nそうじゃなければ何も言わないけどな！");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
