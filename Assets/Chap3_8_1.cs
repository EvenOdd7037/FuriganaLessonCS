using UnityEngine;

public class Chap3_8_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] team ={"A","B","C","D"};
        foreach(string t1 in team)
        {
            foreach(string t2 in team)
            {
                if(t1 != t2)
                {
                Debug.Log(t1 +"vs"+ t2);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
