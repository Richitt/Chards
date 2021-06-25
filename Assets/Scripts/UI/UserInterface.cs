using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TextBox;
    private GameObject texto;
    private bool outo = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
            if(!outo)
            {
                Debug.Log("came in here " );
                texto = Instantiate(TextBox, gameObject.transform);
                texto.GetComponent<PopUpSystem>().TextIn("testo");
                outo = true;
            }
            else{
                texto.GetComponent<PopUpSystem>().PopDown();
                outo = false;
            }
    }
}
