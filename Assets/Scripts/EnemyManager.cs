using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] public GameObject enemyPrefab;

    void Start()
    {
        for (int i = -4; i <= 4; i+=2) {
            var position = new Vector3(i, 0, 10f);
            Instantiate(enemyPrefab, position, Quaternion.identity);
        }
    }
}
