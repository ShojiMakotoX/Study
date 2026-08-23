using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
    void SayHello()//引数・返り値なしメソッド作成
    {
        Debug.Log("hello");
    }
    void CallName(string name)//引数ありメソッド作成
    {
        Debug.Log("Hello" + name);
    }
    int Add(int a,int b)//引数・返り値ありメソッド作成
    {
        int c = a + b;
        return c;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SayHello();//呼び出し
        CallName("Denshi");

        int answer;
        answer = Add(2, 3);//値を拾って
        Debug.Log(answer);//表示

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}