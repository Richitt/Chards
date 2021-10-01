using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PopUpSystem : MonoBehaviour
{
    public TMP_Text popUpText;
    private Animator myAnimator;
    //private bool outo = false;

    void Start(){
        myAnimator = transform.GetComponent<Animator>();
    }
    void Update()
    {
        
    }

    public void TextIn(string text)
    {
        popUpText.text = text;
    }
    public void SelfDestruct(){
        Destroy(gameObject);
    }
    public void PopDown()
    {
        myAnimator.Play("ReversePop");
    }
}