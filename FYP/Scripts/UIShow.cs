using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShow : MonoBehaviour
{
    public GameObject uiobject;
    // Start is called before the first frame update
    void Start()
    {
        uiobject.SetActive(false);   
    }
    void OnTriggerEnter(Collider Player)
    {
        uiobject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
