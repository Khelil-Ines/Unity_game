using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateLevelButton : MonoBehaviour
{
    Menu menu;
    public int id=1;
    public GameObject cadna;
    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.FindGameObjectWithTag("Menu").GetComponent<Menu>();
        if(id == 2)
        {
            if (!menu.isScene2Active)
            {
                GetComponent<Button>().interactable = false;
                cadna.SetActive(true);
            }
        }
        if (id == 3)
        {
            if (!menu.isScene3Active)
            {
                GetComponent<Button>().interactable = false;
                cadna.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
