using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFall : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody コンポーネントを取得
        rb = GetComponent<Rigidbody>();
        // Rigidbodyを動的にしないように設定（キー入力まで静止している）
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Cキーが押されたかを検出
        if (Input.GetKeyDown(KeyCode.C))
        {
            // 壁の上部に力を加えるための位置を計算
            Vector3 forcePoint = transform.position + transform.TransformDirection(new Vector3(0, transform.localScale.y / 2, 0));
            Vector3 forceDirection = transform.right; // またはカメラや特定の方向に合わせて調整
            // Rigidbodyを動的にして物理法則の影響を受けさせる
            rb.isKinematic = false;
            // ゆっくり倒れるように小さな力を加える
            float forceMagnitude = 400f; // 適宜調整

            // 力を加える
            GetComponent<Rigidbody>().AddForceAtPosition(forceDirection * forceMagnitude, forcePoint, ForceMode.Force);
        }
    }
}
