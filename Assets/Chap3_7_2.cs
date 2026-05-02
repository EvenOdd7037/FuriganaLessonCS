using UnityEngine;

public class Chap3_7_2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] dirs ={"東","西","南","北"};
        for(int cnt = 0; cnt<4; cnt++)
        {
            Debug.Log(dirs[cnt]+"方向");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
