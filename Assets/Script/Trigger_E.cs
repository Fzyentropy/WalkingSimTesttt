using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_E : MonoBehaviour
{

    public bool isTriggered = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("进来了");
        
        if(other.gameObject.tag == "Player")
        {
            isTriggered = true;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        // Debug.Log("一直在里面");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("出去了");

        if(other.gameObject.tag == "Player")
        {
            isTriggered = false;
        }
    }







}
