using UnityEngine;
using System.Collections;

public class RotateObj : MonoBehaviour {

    float rotSpeed = 10;

    private void OnMouseDrag()
    {
        float rotx = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;

        transform.RotateAround (Vector3.up, rotx);
    }
}
