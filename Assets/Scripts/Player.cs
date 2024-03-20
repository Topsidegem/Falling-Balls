using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Player : MonoBehaviour
{
    [SerializeField] private int puntos = 0;
    [SerializeField] private int vidas = 3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GoodBall")) 
        {
            puntos++; 
            other.gameObject.SetActive(false);
        }

        if (other.CompareTag("BadBall"))
        {
            EditorApplication.isPlaying = false;
        }
    }
}
