using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIMelee : MonoBehaviour
{

    float Timer = 2.0f;
    public GameObject Player;
    float Range = 5;
    public Rigidbody2D rb;
    public Vector3 offset;
    public float Speed = 5.0f;
    public Transform tr;
    public PlayerController pc;
    public int health = 10;
    public StatusEffectEnemy SEE;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        pc = Player.GetComponent<PlayerController>();
        tr = Player.GetComponent<Transform>();
        SEE = gameObject.GetComponent<StatusEffectEnemy>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Timer > 0.0)
        {
            Timer -= Time.deltaTime;
        }

        float Distance = Vector2.Distance(transform.position, Player.transform.position);
        var ray = Physics2D.Raycast(transform.position, new Vector3(10, 0, 0), 6);

        if (Distance > Range && Timer <= 0.0 && SEE.Frozen == false)
        {
            rb.velocity = new Vector2(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));
            Timer = 2.0f;
        }
        else if (Distance < Range && SEE.Frozen == false)
        {
            Vector3 desiredPosition = tr.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, Speed);
            transform.position = smoothedPosition;

            if (Distance <= Range - 3.5f && Timer <= 0.0f)
            {
                pc.Health -= 1;
                Timer = 2.0f;
            }
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.name != "Player")
        {
            health -= 1;
        }
    }
}
