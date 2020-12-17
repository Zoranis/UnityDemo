using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("TestRepeat", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }


    private void TestRepeat()
    {
        Debug.Log(Time.time + " Repeat works! (GameController.cs)");
    }
}
