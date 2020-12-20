using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_UIShow : MonoBehaviour
{
    public GameObject uiobject;
    
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        uiobject.SetActive(false);

    }
    void OnTriggerEnter(Collider Player)
    {
        uiobject.SetActive(true);
        
       
    }
    void OnTriggerExit(Collider Player)
    {
        //uiobject.SetActive(false);
     
    }


}
