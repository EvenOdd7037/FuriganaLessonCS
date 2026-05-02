using UnityEngine;

public class Chap3_8_3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      string[] team ={"A","B","C","D"};
      int start = 1;
      foreach(string t1 in team)    //まずt1=team[0]="A"
        {
            for(int cnt=start; cnt<4; cnt++)
            {
                Debug.Log(t1 + "vs" +team[cnt] );   //初手ではteam[cnt]=team[1]="B" そこからC(2),D(3)へ
            }
            start++;    //初手ではstart+1=2がstartとなる。Bチームに移った時は、最初team[cnt]=team[2]="C"で"D"へとなる
        }   //この繰り返しでt1=team[2]="C"の時ではstart=3でteam[cnt]では"D"しか出されない。
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
