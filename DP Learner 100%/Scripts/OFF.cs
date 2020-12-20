using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OFF : MonoBehaviour
{
    public GameObject direction;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider Player)
    {
        direction.SetActive(true);


    }
    // Update is called once per frame
    
}
