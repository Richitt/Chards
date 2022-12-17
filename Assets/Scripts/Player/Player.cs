using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public GameObject timingBar;
    public bool slashstart;
    private IEnumerator coroutine;
    public GameObject[] enemies  = new GameObject[0];
    private int selector;
    private Vector3 startPosition;

    private GameObject selectedTarget;
    private string currentAnimation;
    // Start is called before the first frame update
    void Start()
    {   
        selector = -1;
        enemies = this.transform.parent.GetComponent<BattleManager>().existingEnemies();
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
        
       if(Input.GetKeyDown(KeyCode.A)){
           selectTarget();
       }
    }

    public void StartAttack(){
            startPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
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
    public GameObject returnTarget(){
        return selectedTarget;
    }

    private void selectTarget(){
        selector++;
        if(selector > enemies.Length-1){
            selector = 0;
        }
        //if (targetEnemies.Length == 0){
            //targetEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        //}
        selectedTarget = enemies[selector];
        Debug.Log(selectedTarget.name);
    }

    private void returnToStart(){
        transform.position = startPosition;
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        //find the parent of the collider i hit, then proceed to call the minus health method to subtract the right amount of hp.
        other.gameObject.GetComponent<EnemyBehavior>().minusHealth(50);
    }
}
