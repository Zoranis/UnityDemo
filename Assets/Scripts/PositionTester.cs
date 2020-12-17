using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PositionTester : MonoBehaviour
{
    Vector3 stageDimensions;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Input.mousePosition + " " + Screen.width + " " + Screen.height);
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        Debug.Log(stageDimensions);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Transform: " + transform.position);
        //Debug.Log("Camera: " + Camera.main.WorldToScreenPoint(transform.position).ToString());
        //Debug.Log("Prediction: " + Camera.main.ScreenToWorldPoint(transform.position).ToString());
        ////cam.WorldToScreenPoint(target.position);
        //Debug.Log(stageDimensions + " " + transform.position);
    }

}
