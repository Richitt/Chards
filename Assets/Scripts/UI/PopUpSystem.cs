using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PopUpSystem : MonoBehaviour
{
    public TMP_Text popUpText;
    private Animator myAnimator;
    private bool outo = false;

    void Start(){
        myAnimator = transform.GetComponent<Animator>();
    }
    void Update()
    {
        
    }

    public void TextIn(string text)
    {
        
        Debug.Log("came in here 222" );
        popUpText.text = text;
    }
    public void SelfDestruct(){
        Debug.Log("boom");
        Destroy(gameObject);
    }
    public void PopDown()
    {
        Debug.Log("came in here 333");
        myAnimator.Play("ReversePop");
    }
}