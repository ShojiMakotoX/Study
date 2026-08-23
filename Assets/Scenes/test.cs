using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
   
    


    void Start()
    {
        Vector2 playerPos = new Vector2(3.0f, 4.0f);//ベクトルを作る
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}