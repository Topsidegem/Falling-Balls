using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public PoolBalls pool;

    public float count;

    private void Start()
    {
        pool = gameObject.GetComponentInParent<PoolBalls>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            pool.DespawnObject(gameObject);
        }

        if (other.CompareTag("Despawn"))
        {
            print("entro");
            pool.DespawnObject(gameObject);
        }
    }
}
