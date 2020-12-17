using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{

    [SerializeField]
    private bool useDebug = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (useDebug)
        {
            //float translation = Input.GetAxis("Vertical");
            //float rotation = Input.GetAxis("Horizontal");

            //Debug.Log("translation: " + translation);
            //Debug.Log("rotation: " + rotation);
        }
        
    }
}
