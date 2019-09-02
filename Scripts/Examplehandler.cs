using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Examplehandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 newPosition;
    private Vector3 delta;
    private Vector3 startPosition;

    void Awake()
    {
        // Move the Cube away from the origin.
        startPosition = new Vector3(0.25f, -0.5f, 3.0f);
        transform.position = startPosition;

        newPosition = Vector3.zero;
        delta = Vector2.zero;

        // Position the camera and switch to solid color.
        Camera.main.transform.position = new Vector3(0.5f, 1.0f, -3.0f);
        Camera.main.transform.localEulerAngles = new Vector3(15.0f, -20.0f, 0.0f);
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag: " + eventData.pointerPressRaycast.screenPosition);

        // Obtain the position of the hit GameObject.
        delta = eventData.pointerPressRaycast.worldPosition;
        delta = delta - transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        newPosition = eventData.pointerCurrentRaycast.worldPosition - delta;

        if (eventData.pointerCurrentRaycast.worldPosition.x == 0.0f ||
            eventData.pointerCurrentRaycast.worldPosition.y == 0.0f)
        {
            newPosition = eventData.delta;

            transform.Translate(newPosition * Time.deltaTime);
            return;
        }

        transform.position = newPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

        transform.position = startPosition;
    }
}