using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousecontroller : MonoBehaviour
{ 
    void Update()
    {
        Vector3 temp=Input.mousePosition;
        temp.z = 0;
        this.transform.position = Camera.main.ScreenToWorldPoint(temp);
    }
}
