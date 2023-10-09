using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        // 弾を前進させる
        transform.Translate(Vector3.forward * 0.1f);

        if (transform.position.z > 100) {
            // 弾が一定距離以上進んだら破棄する
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision) {
        // 衝突したら破棄する
        Destroy(gameObject);
    }
}
