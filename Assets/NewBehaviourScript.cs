using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 0.5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 0.5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.5f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left *  0.5f);
        }
    }
    void OnCollisionEnter (Collision collision)
    {
        Debug.Log("衝突したオブジェクト: " + collision.gameObject.name);
    }
}
