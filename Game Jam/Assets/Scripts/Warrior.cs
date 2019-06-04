using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{

    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float distance = Vector2.Distance(transform.position, Enemy.transform.position);
            var x = Physics2D.Raycast(transform.position, new Vector3(-10, 0, 0), 6);

            if (distance <= 0.5)
            {
                Destroy(Enemy.gameObject);
            }
        }
    }
}
