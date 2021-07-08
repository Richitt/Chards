using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    private GameObject selectedTarget;
    public GameObject[] enemies;
    private int selector;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        selector = -1;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.A)){
           selectTarget();
       }
    }

    private void selectTarget(){
        selector++;
        if (enemies.Length == 0){
            enemies = GameObject.FindGameObjectsWithTag("Enemy");
        }
        selectedTarget = enemies[selector];
        Debug.Log(selectedTarget.name);
    }
}
