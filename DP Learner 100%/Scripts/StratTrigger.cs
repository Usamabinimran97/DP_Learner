using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StratTrigger : MonoBehaviour
{
    public GameObject Next;
    // Start is called before the first frame update
    void Start()
    {
        Next.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerExit(Collider Player)
    {
        Next.SetActive(true);
        /*cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        cam.rect = new Rect(0f, 0f, 1f, 1f);*/
    }
}
