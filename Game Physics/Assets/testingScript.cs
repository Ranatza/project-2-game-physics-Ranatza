using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        Debug.Log("OnTriggerEnter");
    }

    void OnTriggerStay()
    {
        Debug.Log("OnTriggerStay");
    }
    
    void OnTriggerExit()
    {
        Debug.Log("OnTriggerExit");
    }
        
    void OnCollisionEnter()
    {
        Debug.Log("OnCollisionEnter");
    }
        
    void OnCollisionStay()
    {
        Debug.Log("OnCollisionStay");
    }
        
    void OnCollisionExit()
    {
        Debug.Log("OnCollisionExit");
    }
}
