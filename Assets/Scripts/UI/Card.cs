using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private int distance = 0;
    private int travelled = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
