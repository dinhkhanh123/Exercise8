using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuButtonScript : MonoBehaviour
{

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(InvokeDestroyEvent);
    }

    private void InvokeDestroyEvent()
    {
        EventManager.InvokeDestroyEvent();
    }

}
