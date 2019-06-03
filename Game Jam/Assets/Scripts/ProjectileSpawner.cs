using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{

    public GameObject myPrefab;
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

        if(distance >= 5)
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
                Instantiate(myPrefab, transform.position, Quaternion.identity);
                Timer = 2.0f;
            }
        }
        //Debug.Log("Distance: " + x.distance);
        
    }
}
