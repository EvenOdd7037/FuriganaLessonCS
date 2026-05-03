using UnityEngine;

public class Chap3_10_2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] dirs = {"東","西","南","北"};
        for(int cnt = 3; cnt >=0; cnt--)
        {
            Debug.Log(dirs[cnt]+"方向");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
