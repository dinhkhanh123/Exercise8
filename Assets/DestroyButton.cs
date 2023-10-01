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
        // ?ây là n?i b?n có th? thêm mã x? lý khi s? ki?n ???c g?i
    }
}
