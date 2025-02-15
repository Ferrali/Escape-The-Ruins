using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorTrap : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] DoorSpikeTrap doorspiketrap;
    private bool interaction = false;

    void Update()
    {
        if (interaction && Input.GetKeyDown(KeyCode.E))
        {
            doorspiketrap.trigger();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.SetActive(true);
            interaction = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.SetActive(false);
            interaction = false;
        }
    }
}
