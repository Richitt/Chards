using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int selector;
    public GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        selector = -1;
        foreach (GameObject player in players){
            var p = Instantiate(player);
            p.transform.parent = gameObject.transform;
        }
        foreach (GameObject enemy in enemies){
            var e = Instantiate(enemy);
            e.transform.parent = gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    public GameObject[] existingEnemies(){
        //return existing enemies;
        return this.enemies;
    }
}
