using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //skrypt daje mo�liwo�� �ledzenia gracza, bez mo�liwo�ci obracania kamery myszk�, r�wnie� umo�liwaia zmiane widok�w kamery
    //umie�ci� na kamerze 
    public GameObject player;
    private Vector3 offset = new Vector3(0, 0, 0);
    private Vector3 offset1 = new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 2, 1);

    void Start()
    {
        offset = offset1;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

        //Camera switch
        if (Input.GetKeyDown(KeyCode.P))
        {
            offset = offset2;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            offset = offset1;
        }
    }

}
