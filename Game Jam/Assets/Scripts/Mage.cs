using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{

    public GameObject myPrefab;
    public GameObject myPrefab2;
    public GameObject myPrefab3;
    float Timer = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > 0.0)
        {
            Timer -= Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0) && Timer <= 0.0)
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
}
