using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Healer : MonoBehaviour
{

    //public PlayerController pc;
    //public GameObject Enemy;
    //public float Timer = 0.0f;
    public GameObject Camera;
    public GameManagement GM;


    // Start is called before the first frame update
    void Start()
    {
        //pc = GetComponent<PlayerController>();
        Camera = GameObject.Find("Main Camera");
        GM = Camera.GetComponent<GameManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Timer > 0)
        //{
        //    Timer -= Time.deltaTime;
        //}
        //if (Input.GetMouseButtonDown(0))
        //{
        //    float distance = Vector2.Distance(transform.position, Enemy.transform.position);
        //    var x = Physics2D.Raycast(transform.position, new Vector3(-10, 0, 0), 6);

        //    if (distance <= 0.5)
        //    {
        //        Destroy(Enemy.gameObject);
        //    }
        //}
        //else if (Input.GetMouseButtonDown(1))
        //{
        //    if (Timer <= 0)
        //    {
        //        pc.Health += 1;
        //        Timer = 2.0f;
        //    }
        //}
    }

    public void Healers()
    {
        GM.Healer = true;
        SceneManager.LoadScene("Forest Maze");
    }
}
