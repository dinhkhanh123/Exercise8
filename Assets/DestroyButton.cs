using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyButton : MonoBehaviour
{
    private void Start()
    {
        EventManager.AddDestroyEventInvoker(this);
    }

    public void AddDestroyEventListener()
    {
        // ?�y l� n?i b?n c� th? th�m m� x? l� khi s? ki?n ???c g?i
    }
}
