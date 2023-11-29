using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public Sprite[] sprites;
    Image image;
    public bool done= false;
    int i=0;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        InvokeRepeating("Turnclock", 30, 30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Turnclock()
    {
        i++;
        image.sprite = sprites[i];
        if(i == sprites.Length - 1)
        {
            done = true;
            CancelInvoke();
        }
    }
}
