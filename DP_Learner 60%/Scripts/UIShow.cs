using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShow : MonoBehaviour
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
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        cam.rect = new Rect(0f, 0f, 0.5f, 1f);
        //Camera.main.rect = new Rect(0f, 0f, 0.5f, 1f);
    }
    void OnTriggerExit(Collider Player)
    {
        uiobject.SetActive(false);
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        cam.rect = new Rect(0f, 0f, 1f, 1f);
    }
    // Update is called once per frame
    
}
