using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
   
    


    void Start()
    {
        Vector2 startPos = new Vector2(2.0f, 1.0f);//ベクトルを作る
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;//ベクトル同士の減算を行う
        Debug.Log(dir);

        float len = dir.magnitude;//magnitudeは、dirの長さに等しい。
        Debug.Log(len);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}