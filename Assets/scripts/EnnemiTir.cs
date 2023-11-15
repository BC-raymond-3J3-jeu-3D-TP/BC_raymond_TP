using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnnemiTir : MonoBehaviour
{
    /*#################################################
   -- variables publiques � d�finir dans l'inspecteur
   #################################################*/
    public GameObject balle; // R�f�rence au gameObject de la balle
    public GameObject particuleBalle; // R�f�rence au gameObject � activer lorsque le personnage tir
    public float vitesseBalle; // Vitesse de la balle

    /*#################################################
   -- variables priv�es
   #################################################*/
    private bool peutTirer; // Est-ce que le personnage peut tirer



    void Start()
    {
        peutTirer = true;
    }




    void Update()
    {


        if (peutTirer)
        {
            Tir();
        }
    }

    void Tir()
    {
        peutTirer = false;
        if (Time.timeSinceLevelLoad < 60)
        {
            Invoke("ActiveTir", 1f);
        }
        else if (Time.timeSinceLevelLoad > 60)
        {
            Invoke("ActiveTir", 0.5f);
        }

        particuleBalle.SetActive(true);
        GetComponent<AudioSource>().Play();

        GameObject nouvelleBalle = Instantiate(balle, balle.transform.position, balle.transform.rotation);

        nouvelleBalle.SetActive(true);
        nouvelleBalle.GetComponent<Rigidbody>().velocity = nouvelleBalle.transform.forward * vitesseBalle;
    }

    void ActiveTir()
    {
        peutTirer = true;
        particuleBalle.SetActive(false);
    }
}
