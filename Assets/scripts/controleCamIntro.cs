using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controleCamIntro : MonoBehaviour
{
    public GameObject pivotCam;


    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotCam.transform.position, Vector3.up, 0.01f);
        transform.LookAt(pivotCam.transform.position);
    }

    public void Commencer()
    {
        SceneManager.LoadScene(1);
    }

    public void Instructions()
    {
        SceneManager.LoadScene(2);
    }
}
