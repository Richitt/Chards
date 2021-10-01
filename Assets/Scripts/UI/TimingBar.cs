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
    }
    
    public void receiver(bool yay){
        coroutine = WaitAndCheck(0.1f, yay);
        StartCoroutine(coroutine);
    }
    private void checkAttack(bool yay){
        if(yay){
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
