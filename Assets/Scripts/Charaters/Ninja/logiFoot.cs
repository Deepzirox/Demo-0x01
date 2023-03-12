using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logiFoot : MonoBehaviour
{
    public Move logPerson;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other){
        logPerson.icanJump = true;
    }
    
    private void OnTriggerExit(Collider other){
        logPerson.icanJump = false;
        
    }
}
