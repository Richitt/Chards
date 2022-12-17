using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingBar : MonoBehaviour
{
    public GameObject bar;
    private IEnumerator coroutine;

    private Player Playero;

    // Start is called before the first frame update
    void Start()
    {
        var movebar = Instantiate(bar, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        movebar.transform.parent = gameObject.transform;
        Playero = transform.parent.GetComponent<Player>();
    }
    // Update is called once per frame
    void Update()
    {
        Playero = transform.parent.GetComponent<Player>();
    }
    
    public void receiver(bool yay){
        coroutine = WaitAndCheck(0.1f, yay);
        StartCoroutine(coroutine);
    }
    private void checkAttack(bool yay){
        if(yay){
            //var speed = 2.0f;
            //var target = Playero.returnTarget();
            
            //transform.parent.GetComponent<Rigidbody2D>().velocity = (target.transform.position - transform.position).normalized * speed; 
            //var dir = new Vector3(target.transform.position.x - transform.position.x,target.transform.position.y - transform.position.y, target.transform.position.z - transform.position.z).normalized*speed;
            //transform.parent.GetComponent<Rigidbody2D>().velocity = dir;
            transform.parent.position = new Vector3(Playero.returnTarget().transform.position.x+1, Playero.returnTarget().transform.position.y+1, Playero.returnTarget().transform.position.z);
            Playero.PlayAnimation("SolaSlashFollow");
        }
    }
    private IEnumerator WaitAndCheck(float waitTime, bool yay){
        yield return new WaitForSeconds(waitTime);
        checkAttack(yay);
        Destroy(transform.gameObject);
    }
}
