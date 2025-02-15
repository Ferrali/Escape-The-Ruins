using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Sign : MonoBehaviour
{
    [SerializeField] private GameObject text;
    private bool interaction = false;

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
