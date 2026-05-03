using System;
using UnityEngine;

public class Chap3_6_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] dirs ={"東", "西", "南", "北"};
        Debug.Log(dirs[1]);
        dirs[0] = "真東";
        Debug.Log(string.Join("ぷ", dirs));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
