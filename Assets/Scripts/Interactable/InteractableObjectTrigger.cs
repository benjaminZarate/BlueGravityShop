using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObjectTrigger : MonoBehaviour
{
    [SerializeField] private InteractableObject interactableObject;
    private void OnTriggerEnter2D(Collider2D other)
    {
        interactableObject.SetInContact(other.CompareTag("Player"));
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        interactableObject.SetInContact(false);
    }
}
