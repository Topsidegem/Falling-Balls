using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Player : MonoBehaviour
{
    [SerializeField] private int puntos = 0;
    [SerializeField] private int vidas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GoodBall")) 
        {
            puntos++; 
            other.gameObject.SetActive(false);
        }

        if (other.CompareTag("BadBall"))
        {
            vidas -= 1;
            if(vidas <= 0)
            {
                EditorApplication.isPlaying = false;
            }
        }
    }
}
