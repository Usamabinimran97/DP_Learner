using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSplit : MonoBehaviour
{
    //private GameObject cam;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        //cam = GameObject.Find("MainCamera").GetComponent<Camera>();
        //cam = GameObject.FindGameObjectsWithTag("MainCamera");
        cam.rect = new Rect(0f, 0f, 0.5f, 1f);
        Camera.main.rect = new Rect(0f, 0f, 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
