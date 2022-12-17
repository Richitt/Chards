using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public int healthPoints;
    public GameObject healthBar;
    private GameObject myBar;
    void Start()
    {
       healthPoints = 100; 
       myBar = Instantiate(healthBar, new Vector3(transform.position.x-1, transform.position.y + 1.5f, transform.position.z), Quaternion.identity);

        myBar.transform.parent = gameObject.transform;
        myBar.transform.localScale = new Vector3(0.01f,0.01f,0.01f);
        myBar.GetComponent<HealthBarScript>().setHealth(100);
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
        myBar.GetComponent<HealthBarScript>().minusHealth(damage);
        Debug.Log("curr health " + this.healthPoints);
        if (this.healthPoints == 0){
            Destroy(transform.gameObject);
        }
    }
    public void plusHealth(int healing){
        this.healthPoints += healing;
        Debug.Log("curr health " + this.healthPoints);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
    }
}
