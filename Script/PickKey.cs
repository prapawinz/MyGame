using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
    public Component doorkuy;
    public GameObject keygone;

    void Start()
    {
        
    }

    
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            doorkuy.GetComponent<BoxCollider>().enabled = true;
            
        }

        if(Input.GetKey(KeyCode.E))
        {
            keygone.SetActive(false);
        }


    }
}
