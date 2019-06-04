using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{

    public GameObject myPrefab;
    public GameObject myPrefab2;
    public GameObject myPrefab3;
    public GameObject player;

    public float Timer = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float distance = Vector2.Distance(transform.position, player.transform.position);
        var x =  Physics2D.Raycast(transform.position, new Vector3(10,0,0), 6);

        if (distance >= 5)
        {
            Debug.Log("Out of range");
        }
        else
        {
            if (Timer > 0 && x.distance <= 5)
            {
                Timer -= Time.deltaTime;
            }
            else if (Timer <= 0 && x.distance <= 5)
            {
                var Rand = Random.Range(0, 3);
                Debug.Log("Rand: " + Rand);
                if (Rand == 0)
                {
                    Instantiate(myPrefab, transform.position, Quaternion.identity);
                    Timer = 2.0f;
                }
                if (Rand == 1)
                {
                    Instantiate(myPrefab2, transform.position, Quaternion.identity);
                    Timer = 2.0f;
                }
                if (Rand == 2)
                {
                    Instantiate(myPrefab3, transform.position, Quaternion.identity);
                    Timer = 2.0f;
                }
            }
        }
        //Debug.Log("Distance: " + x.distance);
        
    }
}
