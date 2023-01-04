using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brushclick : MonoBehaviour
{
    public GameObject paint;
    public GameObject erase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonOnClicked()
    {
        erase.SetActive(false);
        paint.SetActive(true);
    }
}
