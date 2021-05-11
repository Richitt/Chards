using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarLogic : MonoBehaviour
{
    private Vector3 pos1;
    private Vector3 pos2;
    public Vector3 posDistance;
    public Vector3 posStart;
    public float speed = 1.0f;
    private Vector3 start;
    
    public bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        var sprite = transform.parent.GetComponent<SpriteRenderer>();
        posStart = new Vector3(sprite.bounds.extents.x, 0f, 0f);
        posDistance = new Vector3(sprite.bounds.extents.x, 0f, 0f);
        start = transform.position;
        pos1 = transform.position - posStart;
        pos2 = transform.position + posDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (active){
            transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time*speed, 1.0f));
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            active = false;
            checkAttack();
        }
    }
    private void checkAttack(){
        bool yay = false;
        Debug.Log("transform " + transform.position.x);
        Debug.Log("start " + start.x);
        if(Mathf.Abs(transform.position.x - start.x) <0.2){
            yay = true;
        }
        transform.parent.GetComponent<TimingBar>().receiver(yay);
        transform.parent = transform.parent.parent;
        Destroy(transform.gameObject);
    }
}
