using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float forceAmount = 500f; // 力の大きさを調整するための変数

    private Rigidbody rb; // Rigidbodyへの参照を保存するための変数
    // Start is called before the first frame update
    void Start()
    {
        // ゲーム開始時にRigidbodyコンポーネントを取得してrb変数に格納
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーが押されたら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ボールに前方向（z軸方向）に力を加える
            rb.AddForce(transform.forward * forceAmount);
        }
        // if (Input.GetKey(KeyCode.W))
        // {
        //     transform.Translate(Vector3.forward * 0.5f);
        // }
        // if (Input.GetKey(KeyCode.S))
        // {
        //     transform.Translate(Vector3.back * 0.5f);
        // }
        // if (Input.GetKey(KeyCode.D))
        // {
        //     transform.Translate(Vector3.right * 0.5f);
        // }
        // if (Input.GetKey(KeyCode.A))
        // {
        //     transform.Translate(Vector3.left *  0.5f);
        // }
    }
    void OnCollisionEnter (Collision collision)
    {
        Debug.Log("衝突したよ！オブジェクト: " + collision.gameObject.name);
    }
}
