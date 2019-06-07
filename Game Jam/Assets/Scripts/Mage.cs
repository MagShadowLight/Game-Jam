using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mage : MonoBehaviour
{

    //public GameObject myPrefab;
    //public GameObject myPrefab2;
    //public GameObject myPrefab3;
    //public Statuseffect SE;
    //float Timer = 0.5f;
    public GameObject Camera;
    public GameManagement GM;

    // Start is called before the first frame update
    void Start()
    {
        //SE = GetComponent<Statuseffect>();
        Camera = GameObject.Find("Main Camera");
        GM = Camera.GetComponent<GameManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Timer > 0.0)
        //{
        //    Timer -= Time.deltaTime;
        //}

        //if (Input.GetMouseButtonDown(0) && Timer <= 0.0 && SE.Stunned == false)
        //{
        //    var Rand = Random.Range(0, 3);
        //    Debug.Log("Rand: " + Rand);
        //    if (Rand == 0)
        //    {
        //        Instantiate(myPrefab, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
        //        Timer = 0.5f;
        //    }
        //    if (Rand == 1)
        //    {
        //        Instantiate(myPrefab2, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
        //        Timer = 0.5f;
        //    }
        //    if (Rand == 2)
        //    {
        //        Instantiate(myPrefab3, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
        //        Timer = 0.5f;
        //    }
        //}
    }

    public void Mages()
    {
        GM.mage = true;
        SceneManager.LoadScene("Forest Maze");
    }

}
