using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestionCam : MonoBehaviour
{

    public GameObject camSuivi;
    public GameObject camEnsembleA;
    public GameObject camEnsembleB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            camSuivi.SetActive(true);
            camEnsembleA.SetActive(false);
            camEnsembleB.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            camSuivi.SetActive(false);
            camEnsembleA.SetActive(true);
            camEnsembleB.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            camSuivi.SetActive(false);
            camEnsembleA.SetActive(false);
            camEnsembleB.SetActive(true);
        }
    }
}
