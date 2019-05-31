using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Rigidbody2D rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
    }

    // Update is called once per frame
    void Update()
    {
        this.rigidbody.velocity = new Vector2 (2.0f,0.0f);
    }
}
