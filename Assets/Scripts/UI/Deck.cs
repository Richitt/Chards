using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public GameObject[] cards;
    private int counter = 1;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject card in cards){
            var p = Instantiate(card);
            p.transform.parent = gameObject.transform;
            p.transform.position = gameObject.transform.position - new Vector3(3.6f,0,0);
            var x = p.GetComponent<Card>();
            x.setDistance(100 * counter);
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
