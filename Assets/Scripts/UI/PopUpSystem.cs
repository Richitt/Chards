using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
    public TMP_Text popUpText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)){
            Debug.Log("came in here " );
            PopUp("test");
            }
    }

    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUpText.text = text;
        animator.SetTrigger("pop");
    }
}