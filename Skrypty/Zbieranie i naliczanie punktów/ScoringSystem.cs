using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
//Skrypt updejtuje nasz wynik na ekranie

    public GameObject scoreText; //text w UI
    public static int theScore;
    void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "NITRO: " + theScore;
       
    }
}
