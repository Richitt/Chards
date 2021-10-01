using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    private int healthPoints;
    void Start()
    {
       healthPoints = 100; 
    }

    // Update is called once per frame
    void Update()
    {
        setBar();
    }
    private void setBar(){
        //set the display to accurately show health.
    }
    public void minusHealth(int damage){
        this.healthPoints -= damage;
    }
    public void plusHealth(int healing){
        this.healthPoints += healing;
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("ow!");
    }
}
