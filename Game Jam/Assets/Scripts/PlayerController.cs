using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public float speed;
    private Rigidbody2D rb;
    public int Health = 10;

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
            rb.velocity = moveInput;

        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }

    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        Health -= 1;
        Destroy(obj.gameObject);

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
