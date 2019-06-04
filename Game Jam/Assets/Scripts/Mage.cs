using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{

    public GameObject myPrefab;
    public GameObject myPrefab2;
    public GameObject myPrefab3;
    float Timer = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var Rand = Random.Range(0, 3);
            Debug.Log("Rand: " + Rand);
            if (Rand == 0)
            {
                Instantiate(myPrefab, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
                Timer = 2.0f;
            }
            if (Rand == 1)
            {
                Instantiate(myPrefab2, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
                Timer = 2.0f;
            }
            if (Rand == 2)
            {
                Instantiate(myPrefab3, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
                Timer = 2.0f;
            }
        }
    }
}
