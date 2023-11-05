using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Point : MonoBehaviour
{
    public TextMeshProUGUI _Punteggio;
    public int counter;

    private void OnTriggerEnter(Collider collision)
    {
        //print("Trigger enter " + other.gameObject.name);

        if (collision.transform.tag == "Player")
        {
            print("Questo è il collider Utile!!!");

            counter++;
            _Punteggio.text = "Punteggio: " + counter;
        }

    }

}