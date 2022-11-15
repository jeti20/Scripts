using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{//this script is resping object in position of object in which is creaetd
    public GameObject mydlo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch a projectile from the player
            Instantiate(mydlo, transform.position, mydlo.transform.rotation);
            //kolonuje mydlo i zwraca tego klona
            //transform.position --> bo chcemy zeby respi�o si� w pozycji obiketu kt�ry ma na sobie skrypt, w tym przypadku jest to player
            //projectilePrefab.transform.rotation --> mamy ustawiony ju� prefab pizzy i nie chcemy innej rotacji, czyli piszemy, ze rotacja taka jak prefaba pizzy
        }
    }

}
