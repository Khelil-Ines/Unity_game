using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceCheck : MonoBehaviour
{
    public GameObject menu;

    
    void Awake()
    {
        if(Menu.Instance == null)
        {
            Instantiate(menu);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
