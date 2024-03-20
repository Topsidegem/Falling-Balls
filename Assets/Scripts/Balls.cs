using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public PoolBalls pool;

    public float count;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            pool.DespawnObject(gameObject);
        }
    }

    private void Update() {
        count += Time.deltaTime;
        if (count >= 5) {
            pool.DespawnObject(gameObject);
            count = 0;
        }
    }
}
