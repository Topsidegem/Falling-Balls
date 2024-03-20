using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public PoolBalls pool;
    public float count;

    private void Update() 
    {
        count += Time.deltaTime;
        if(count >= 2) 
        {
            Spawn();
            count = 0;
        }
    }

    private void Spawn() 
    {
        GameObject temObj = pool.RequestObject();
        temObj.transform.position = transform.position;
    }
}
