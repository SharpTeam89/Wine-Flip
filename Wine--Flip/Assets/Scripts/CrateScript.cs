using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateScript : MonoBehaviour
{
    EnemyCScript enemy;
    EnemyCScript enemy2;
    public GameObject enemyOb;
    public GameObject enemyOb2;
    public GameObject BrokeParticle;
    public GameObject Výbuch;
    public GameObject Key;

    void Start()
    {
        enemy = enemyOb.GetComponent<EnemyCScript>();
        enemy2 = enemyOb2.GetComponent<EnemyCScript>();
    }

    
    void Update()
    {
        if (enemy.Died == true && enemy2.Died == true)
        {
            Invoke("Destruction", 1);
        }
    }

    public void Destruction()
    {
        Instantiate(Výbuch, transform.position, Quaternion.identity);
        Instantiate(Key, transform.position, Quaternion.identity);
        Instantiate(BrokeParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
