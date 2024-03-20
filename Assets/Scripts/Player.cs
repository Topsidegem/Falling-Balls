using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Player : MonoBehaviour
{
    public int vidas = 3;
    [SerializeField] private int puntos = 0;
    public Menu menuScript;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("GoodBall")) {
            puntos++;
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("BadBall")) {
            vidas--;
            if (vidas <= 0) {
                menuScript.Perdiste();
            }
        }
    }
}
