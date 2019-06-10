using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public EnemyAIMelee AIMelee;
    public EnemyAIRanged AIRanged;
    public GameObject Gold;
    public Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        AIMelee = GetComponent<EnemyAIMelee>();
        AIRanged = GetComponent<EnemyAIRanged>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AIRanged.health <= 0)
        {
            var rand = Random.Range(0, 3);
            Debug.Log("rand: " + rand);
            if (rand >= 1)
            {
                Instantiate(Gold, tr.position, Quaternion.identity);
            }
        }
    }
}
