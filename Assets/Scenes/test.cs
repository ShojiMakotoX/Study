using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int hp = 50;
        if(hp>=100)
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