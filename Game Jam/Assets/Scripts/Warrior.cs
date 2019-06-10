using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warrior : MonoBehaviour
{

    //public GameObject Enemy;
    //public EnemyAIMelee AIMelee;
    public GameObject Camera;
    public GameManagement GM;

    // Start is called before the first frame update
    void Start()
    {
        //AIMelee = Enemy.GetComponent<EnemyAIMelee>();
        Camera = GameObject.Find("Main Camera");
        GM = Camera.GetComponent<GameManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    float distance = Vector2.Distance(transform.position, Enemy.transform.position);
        //    var x = Physics2D.Raycast(transform.position, new Vector3(-10, 0, 0), 6);

        //    if (distance <= 0.8)
        //    {
        //        AIMelee.health -= 1;
        //    }
        //}   
    }

    public void Warriors()
    {
        GameManagement.warrior = true;
        SceneManager.LoadScene("Forest Maze");
    }
}
