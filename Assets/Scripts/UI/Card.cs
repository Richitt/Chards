using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Card : MonoBehaviour
{
    private int distance = 0;
    private int travelled = 0;
    private float damage = 0;
    // Start is called before the first frame update
    void Start()
    {
        damage = Random.Range(25,50);
    }

    // Update is called once per frame
    void Update()
    {
        if (travelled<distance){
            shift();
            travelled++;
        }
    }
    public void shift(){
        transform.position += new Vector3(0.02f, 0, 0);
    }
    
    public void setDistance(int target){
        distance = target;
    }

    public void OnMouseOver(){   
        if (Input.GetMouseButtonDown(0))
        {   
            Debug.Log("a");
            TimingBar bar = this.transform.parent.gameObject.GetComponent<TimingBar>();
            Debug.Log(bar.transform);
        }
    }
}
