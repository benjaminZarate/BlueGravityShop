using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InteractableObject : MonoBehaviour, IPointerDownHandler
{
    private bool isInContactWithPlayer;
    [SerializeField] private Transform interactableParent;
    [SerializeField] private Transform interactableIcon;

    [SerializeField] private UnityEvent OnClick;
    [SerializeField] private UnityEvent OnContact;
    [SerializeField] private UnityEvent OnExit;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isInContactWithPlayer) 
        {
            OnClick?.Invoke();
        }
        Debug.LogWarning("Click");
    }

    public void SetInContact(bool value) 
    {
        isInContactWithPlayer = value;
        if (value)
        {
            interactableIcon.SetParent(interactableParent);
            interactableIcon.localPosition = Vector2.zero;
            OnContact?.Invoke();
        }
        else 
        {
            OnExit?.Invoke();
        }
    }
}
