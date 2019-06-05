using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public float speed;
    private Rigidbody2D rb;
    public int Health = 10;
    public float Speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            rb.velocity = moveInput * Speed;

        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        Health -= 1;
        Destroy(obj.gameObject);

        
    }
}
