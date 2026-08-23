using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
    public class Player//プレイヤークラスを作る（ここはc＋＋とはめちゃ違っているなと思う）
    {
        private int hp = 100;
        private int power = 50;

        public void Attack()//Attack関数の処理
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        public void Damage(int damage)//Damage関数の処理
        {
            this.hp -= damage;
            Debug.Log(damage + "のダメージを受けた");
        }
    }


    void Start()
    {
        Player myPlayer = new Player();//プレイヤークラスが呼び出される
        myPlayer.Attack();//アタック関数が呼び出される
        myPlayer.Damage(30);//ダメージ関数が呼び出される

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}