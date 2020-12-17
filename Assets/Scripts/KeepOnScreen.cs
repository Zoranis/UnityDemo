using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepOnScreen : MonoBehaviour
{
    //This object is being kept on screen by teleporting it from wall to wall.
    [SerializeField]
    private Transform Player;

    float screenTop;
    float screenRight;
    Vector3 stageDimensions;
    
    // Start is called before the first frame update
    void Start()
    {
        //Finding the stage dimensions, and setting screenTop and screenRight.
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        screenTop = stageDimensions.y;
        screenRight = stageDimensions.x;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Player.position.x > screenRight)
        {
            Player.position = new Vector3(-screenRight, Player.position.y, Player.position.z);
        }

        if (Player.position.x < -screenRight)
        {
            Player.position = new Vector3(screenRight, Player.position.y, Player.position.z);
        }

        if (Player.position.y > screenTop)
        {
            Player.position = new Vector3(Player.position.x, -screenTop, Player.position.z);
        }

        if (Player.position.y < -screenTop)
        {
            Player.position = new Vector3(Player.position.x, screenTop, Player.position.z);
        }


    }


}
