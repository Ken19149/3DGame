using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Rigidbody rb;

    public float rightForce = 500f;

    bool holdButton = false;

    public void OnPointerDown(PointerEventData data)
    {
        holdButton = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        holdButton = false;
    }

    void Update()
    {
        if (holdButton)
        {
            rb.AddForce(rightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
