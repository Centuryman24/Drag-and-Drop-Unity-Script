using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropSC : MonoBehaviour
{
    //For the script to work, you must put it in an object that you can drag and that the main camera has the tag "MainCamara"
    public Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2.5f);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
        rb.isKinematic = true;

    }
    private void OnMouseUp()
    {
        rb.isKinematic = false;
    }
}