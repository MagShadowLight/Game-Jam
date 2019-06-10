using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickup : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.name == "Player")
        {
            GameManagement.Gold += 1;
            Destroy(gameObject);
        }
    }
}
