using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTimer : MonoBehaviour
{
    public GameObject Player;
    public Statuseffect SE;
    public float Timer = 6.0f;
    public GameObject Enemy;
    public EnemyAIMelee AIMelee;
    public EnemyAIRanged AIRanged;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 6.0f;
        Player = GameObject.Find("Player");
        SE = Player.GetComponent<Statuseffect>();
        Enemy = GameObject.Find("Enemy");
        AIMelee = Enemy.GetComponent<EnemyAIMelee>();
        AIRanged = Enemy.GetComponent<EnemyAIRanged>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D obj)
    {
        if (gameObject.name == "Fire Ball(Clone)" && (obj.gameObject.name == "Player" || obj.gameObject.name == "Enemy"))
        {
            var Rand = Random.Range(0, 3);
            Debug.Log("Rand: " + Rand);
            if (Rand == 2)
            {
                SE.Burned = true;
            }
        }

        else if (gameObject.name == "Ice Ball(Clone)" && (obj.gameObject.name == "Player" || obj.gameObject.name == "Enemy"))
        {
            var Rand = Random.Range(0, 3);
            Debug.Log("Rand: " + Rand);
            if (Rand == 2)
            {
                SE.Frozen = true;
            }
        }

        else if (gameObject.name == "Lightning Ball(Clone)" && (obj.gameObject.name == "Player" || obj.gameObject.name == "Enemy"))
        {
            var Rand = Random.Range(0, 3);
            Debug.Log("Rand: " + Rand);
            if (Rand == 2)
            {
                SE.Stunned = true;
            }
        }

        Destroy(gameObject);
    }
}
