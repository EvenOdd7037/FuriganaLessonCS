using UnityEngine;

public class Chap3_7_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] dirs ={"東","西","南","北"};
        foreach(string d in dirs)
        {
            Debug.Log(d+"方向");    //dにはdirs各要素がループごとに０番目から最後まで順番に入ります。
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
