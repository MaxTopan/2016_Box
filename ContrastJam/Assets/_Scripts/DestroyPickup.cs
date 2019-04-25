using UnityEngine;
using System.Collections;

public class DestroyPickup : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Col")
        {
            Destroy(other.gameObject);
        }
        else if (other.tag == "MenuItem")
        {
            MenuNav menu = other.GetComponent<MenuNav>();
            if (menu.credits)
            {
                StartCoroutine(menu.LoadCredits());
            }
            else
            {
                StartCoroutine(menu.LoadLevel());
            }
        }
    }
}