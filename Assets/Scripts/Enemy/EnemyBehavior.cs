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
        Debug.Log("curr health " + this.healthPoints);
    }
    public void plusHealth(int healing){
        this.healthPoints += healing;
        Debug.Log("curr health " + this.healthPoints);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
    }
}
