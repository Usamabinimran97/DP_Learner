using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    public GameObject gameObject;
    bool active;
   
    
    public void close()
    {
        
        if (active == false)
        {
            gameObject.transform.gameObject.SetActive(false);
        }
    }
}
