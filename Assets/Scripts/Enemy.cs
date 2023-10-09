using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Bullet") {
            // 衝突した相手が弾だったら破棄する
            Destroy(gameObject);
        }
    }
}
