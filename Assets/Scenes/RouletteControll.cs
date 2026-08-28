using UnityEngine;
using UnityEngine.InputSystem;//入力を検知するために必要。

public class RouletteControll : MonoBehaviour
{
    float rotspeed = 0;//回転速度の初期設定
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //フレームレートを60に固定する
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //マウスが押されたら回転速度を設定する
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            this.rotspeed = 10;
        }
        //回転速度分、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotspeed);

        //ルーレット減速処理
        this.rotspeed *= 0.96f;
    }
}
