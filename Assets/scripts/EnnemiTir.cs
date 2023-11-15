using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnnemiTir : MonoBehaviour
{
    /*#################################################
   -- variables publiques à définir dans l'inspecteur
   #################################################*/
    public GameObject balle; // Référence au gameObject de la balle
    public GameObject particuleBalle; // Référence au gameObject à activer lorsque le personnage tir
    public float vitesseBalle; // Vitesse de la balle

    /*#################################################
   -- variables privées
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
