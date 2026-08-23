using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] points = { 83, 99, 52, 93, 15 };//配列作成
        int sum = 0;
       
        

        //纏めて表示
        for(int i = 0;i<points.Length;i++)
        {
            //90点以上を表示する
            //if (points[i]>=90)
            //{
            //    Debug.Log(points[i]);
            //}

            //合計を求める
            sum += points[i];
        }

        //合計求めたものの平均を
        int average = sum / points.Length;
        Debug.Log(average);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}