using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public GameObject timingBar;
    public bool slashstart;
    private IEnumerator coroutine;

    private string currentAnimation;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        slashstart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if(slashstart == false){
                StartAttack();
                PlayAnimation("SolaSlashStart");
                slashstart = true;
                }
            else{
                //coroutine = WaitAndCheck(0.1f, true);
                //StartCoroutine(coroutine);
                slashstart = false;
                }
            }
    }

    public void StartAttack(){
            var myBar = Instantiate(timingBar, new Vector3(transform.position.x, transform.position.y + 3, transform.position.z), Quaternion.identity);
            myBar.transform.parent = gameObject.transform;
    }

    //private IEnumerator WaitAndCheck(float waitTime, bool yay){
        //yield return new WaitForSeconds(waitTime);
        //checkAttack(yay);
    //}

    public void PlayAnimation(string newAnimation)
    {
        if (currentAnimation == newAnimation) return;

        animator.Play(newAnimation);
        currentAnimation = newAnimation;
    }
}
