using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Function_Read : MonoBehaviour
{

    public Trigger_E TE;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Read();
    }


    public void Read()
    {
        if(TE.isTriggered)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("EEEEEEf");
            }
        }
    }











}
