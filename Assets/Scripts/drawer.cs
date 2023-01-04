using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.IO;
public class drawer : MonoBehaviour
{
    public GameObject sketch;
    public RenderTexture RTexture;
    GameObject brush;
    Plane plane;
    Vector3 startpos;

    // Start is called before the first frame update
    void Start()
    {
        plane = new Plane(Camera.main.transform.forward, new Vector3(0,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            brush = (GameObject)Instantiate(sketch, this.transform.position, Quaternion.identity);
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distance;
            
            if (plane.Raycast(ray, out distance))
            {
                startpos = ray.GetPoint(distance);
            }
        }
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distance;
            if (plane.Raycast(ray, out distance))
            {
                brush.transform.position = ray.GetPoint(distance);
            }
        }
    }
/*    public void Save()
    {
        RenderTexture.active = RTexture;
        var texture2D = new Texture2D(RTexture.width, RTexture.height);
        texture2D.ReadPixels(new Rect(0, 0, RTexture.width, RTexture.height), 0, 0);
        texture2D.Apply();
        var data = texture2D.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/savedImage.png", data);
    }
*/
}

