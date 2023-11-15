using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlePivot : MonoBehaviour
{
    public GameObject cible;
    public GameObject cameraSuivi;
    //public GameObject posRaycastSuivi;
    public float hauteurPivot;
    //public float distanceCameraLoin = -4f;
    //public float distanceCameraPret = 0.5f;
    public bool curseurLock;

    // Update is called once per frame
    void Update()
    {
        
        if (soldierControle.estMort == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            transform.position = cible.transform.position + new Vector3(0, hauteurPivot, 0);
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0);
            transform.Rotate(Input.GetAxis("Mouse Y") * 3f, Input.GetAxis("Mouse X") * 3f, 0);
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            cameraSuivi.transform.RotateAround(cible.transform.position + new Vector3(0, hauteurPivot, 0), Vector3.up, 0.01f);
            cameraSuivi.transform.LookAt(cible.transform.position + new Vector3(0, hauteurPivot, 0));
        }


        /*if (Physics.Raycast(posRaycastSuivi.transform.position, posRaycastSuivi.transform.forward, -distanceCameraLoin))
        {
            cameraSuivi.transform.localPosition = new Vector3(0, 1, distanceCameraPret);
        }
        else
        {
            cameraSuivi.transform.localPosition = new Vector3(0, 0, distanceCameraLoin);
        }
        cameraSuivi.transform.LookAt(transform);*/

    }
}
