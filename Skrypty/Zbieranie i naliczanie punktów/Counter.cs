using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{// skrypt powoduje zebranie + wydanie dŸwiêku + dodanie punktu do naliczania
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        collectSound.Play();
        ScroingSystem.theScore += 0.5;
        Destroy(gameObject);
    }
}
