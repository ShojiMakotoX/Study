using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int hp = 180;
        if(hp<=50)
        {
            Debug.Log("逃走");
        }
        else if(hp>= 200)
        {
            Debug.Log("攻撃");
        }
        else
        {
            Debug.Log("防御");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}