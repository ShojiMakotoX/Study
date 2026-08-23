using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] array = new int[5];//配列作成
        //データ入力
        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        //纏めて表示
        for(int i = 0;i<5;i++)
        {
            Debug.Log(array[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}