using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -8.5f; //"static", pozwoli dowolnemu skryptowi na interakcj� z t� zmienn� w najprostszy spos�b. Kiedy jest statyczna, inne skrypty mog� wchodzi� w interakcje z t� zmienn�
    public static float rightSide = 8.5f;
    public float internalLeft;
    public float internalRight;
    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
