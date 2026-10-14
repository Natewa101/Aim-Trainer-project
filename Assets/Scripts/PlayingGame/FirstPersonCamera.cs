using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{

    //varaibles
    public Transform player;
    public float MouseSens = 2f;
    float cameraVerticalRotation = 0;

    bool lockedCursor = true;
    // Start is called before the first frame update
    void Start()
    {
        //locks and hides the cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Mouse X")* MouseSens;
        float inputY = Input.GetAxis("Mouse Y")* MouseSens;

        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        player.Rotate(Vector3.up * inputX);
    }
}
