using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public static class EventManager
{
    private static List<DestroyButton> destroyEventInvokers = new List<DestroyButton>();
    private static UnityEvent destroyEvent = new UnityEvent();

    public static void AddDestroyEventInvoker(DestroyButton destroyButton)
    {
        destroyEventInvokers.Add(destroyButton);
        destroyEvent.AddListener(destroyButton.AddDestroyEventListener);
    }

    public static void RemoveDestroyEventInvoker(DestroyButton destroyButton)
    {
        destroyEventInvokers.Remove(destroyButton);
        destroyEvent.RemoveListener(destroyButton.AddDestroyEventListener);
    }

    public static void InvokeDestroyEvent()
    {
        destroyEvent.Invoke();
    }
}
