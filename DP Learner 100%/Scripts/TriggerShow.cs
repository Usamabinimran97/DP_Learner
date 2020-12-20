using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShow : MonoBehaviour
{
    public GameObject Next;
    public GameObject Previous;
    //public GameObject Directionprev;
    // Start is called before the first frame update
    void Start()
    {
        Next.SetActive(false);
    }

    void OnTriggerEnter(Collider Player)
    {
      //  Directionprev.SetActive(false);


    }
    // Update is called once per frame
    void OnTriggerExit(Collider Player)
    {
        Next.SetActive(true);
        Previous.SetActive(false);
        /*cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        cam.rect = new Rect(0f, 0f, 1f, 1f);*/
    }
}
