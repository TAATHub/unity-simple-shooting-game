using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            // スペースキーを押したら弾を生成する
            Instantiate(bulletPrefab, transform.position + Vector3.forward, Quaternion.identity);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow)) {
            // 左キーを押している間は左に移動する
            transform.Translate(Vector3.left * 0.005f);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            // 右キーを押している間は右に移動する
            transform.Translate(Vector3.right * 0.005f);
        }
    }
}
