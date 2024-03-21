using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerControler inputActions;
    [SerializeField] private float speed;
    [SerializeField] private int puntos = 0;
    private Rigidbody2D rb;
    public int vidas = 3;
    public Menu menuScript;

    private void Awake()
    {
        inputActions = new PlayerControler();
    }

    private void Start()
    {
        inputActions.Enable();
        rb = GetComponent<Rigidbody2D>();


    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector2 direction = new Vector2(inputActions.Standard.Movement.ReadValue<float>(), 0).normalized;
        rb.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("GoodBall"))
        {
            puntos++;
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("BadBall")) 
        {
            vidas--;
            if (vidas <= 0) 
            {
                menuScript.Perdiste();
            }
        }
    }
}
