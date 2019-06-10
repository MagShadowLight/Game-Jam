using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public float speed;
    private Rigidbody2D rb;
    public int Health = 10;
    public float Speed = 1.5f;
    public Statuseffect SE;
    public GameObject Enemy;
    public EnemyAIMelee AIMelee;
    public GameManagement GM;
    public GameObject Camera;
    public GameObject myPrefab;
    public GameObject myPrefab2;
    public GameObject myPrefab3;
    float Timer = 0.5f;
    public float Timer2 = 0.0f;
    public EnemyAIRanged AIRanged;
    float Timer3 = 0.0f;
    public GameObject Arrow;

    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("Main Camera");
        rb = GetComponent<Rigidbody2D>();
        SE = GetComponent<Statuseffect>();
        Enemy = GameObject.Find("Enemy");
        AIMelee = Enemy.GetComponent<EnemyAIMelee>();
        GM = Camera.GetComponent<GameManagement>();
        AIRanged = Enemy.GetComponent<EnemyAIRanged>();
        if (GameManagement.warrior == true)
        {
            Health = 15;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if ((Input.GetButton("Horizontal") || Input.GetButton("Vertical")) && SE.Frozen == false )
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

        if (Timer3 > 0)
        {
            Timer3 -= Time.deltaTime;
        }

        if (GameManagement.warrior == true)
        {
            //Debug.Log(GameManagement.warrior);
            if (Input.GetMouseButtonDown(0))
            {
                float distance = Vector2.Distance(transform.position, Enemy.transform.position);
                var x = Physics2D.Raycast(transform.position, new Vector3(-10, 0, 0), 6);

                if (distance <= 1.5)
                {
                    //AIMelee.health -= 1;
                    AIRanged.health -= 1;
                }
            }
            if (Input.GetMouseButtonDown(1) && SE.Stunned == false)
            {
                if (Timer3 <= 0 && GameObject.Find("Arrow(Clone)") == null)
                {
                    Instantiate(Arrow, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
                    var arrow = GameObject.Find("Arrow(Clone)");
                    var arrowRB = arrow.GetComponent<Rigidbody2D>();
                    arrowRB.velocity = new Vector2(0, 0);
                    Timer3 = 0.25f;
                }
            }
            else if (Input.GetMouseButtonUp(1))
            {
                var arrow = GameObject.Find("Arrow(Clone)");
                var arrowRB = arrow.GetComponent<Rigidbody2D>();
                var ArrowPC = arrow.GetComponent<ProjectileController>();
                arrowRB.velocity = ArrowPC.ShotSpeed;
            }
        }

        else if (GameManagement.mage == true)
        {
            if (Timer > 0.0)
            {
                Timer -= Time.deltaTime;
            }

            if (Input.GetMouseButtonDown(0) && Timer <= 0.0 && SE.Stunned == false)
            {
                var Rand = Random.Range(0, 3);
                Debug.Log("Rand: " + Rand);
                if (Rand == 0)
                {
                    Instantiate(myPrefab, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
                    Timer = 0.5f;
                }
                if (Rand == 1)
                {
                    Instantiate(myPrefab2, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
                    Timer = 0.5f;
                }
                if (Rand == 2)
                {
                    Instantiate(myPrefab3, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
                    Timer = 0.5f;
                }
            }
        }

        else if (GameManagement.thief == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                float distance = Vector2.Distance(transform.position, Enemy.transform.position);
                var x = Physics2D.Raycast(transform.position, new Vector3(-10, 0, 0), 6);

                if (distance <= 1.5)
                {
                    //AIMelee.health -= 1;
                    AIRanged.health -= 1;
                }
            }
        }

        else if (GameManagement.Healer == true)
        {
            if (Timer2 > 0)
            {
                Timer2 -= Time.deltaTime;
            }
            if (Input.GetMouseButtonDown(0))
            {
                float distance = Vector2.Distance(transform.position, Enemy.transform.position);
                var x = Physics2D.Raycast(transform.position, new Vector3(-10, 0, 0), 6);

                if (distance <= 0.5)
                {
                    Destroy(Enemy.gameObject);
                }
            }
            else if (Input.GetMouseButtonDown(1))
            {
                if (Timer2 <= 0)
                {
                    Health += 1;
                    Timer2 = 2.0f;
                }
            }
        }

    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.name != "Enemy")
        {
            Health -= 1;
        }
    }
}
