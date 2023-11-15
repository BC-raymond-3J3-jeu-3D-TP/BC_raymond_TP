using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalleEnnemiScript : MonoBehaviour
{

    /*#################################################
    -- variables publiques à définir dans l'inspecteur
    #################################################*/
    public GameObject impactTir; // Référence au Prefab à instancier lorsque le tir frappe un objet. (Prefab ParticulesHit)
    public GameObject personnage; // Référence au personnage


    private void OnCollisionEnter(Collision infoCollisions)
    {

        GameObject particuleCopie = Instantiate(impactTir);
        particuleCopie.transform.position = infoCollisions.GetContact(0).point;
        particuleCopie.SetActive(true);
        particuleCopie.transform.LookAt(personnage.transform);
        Destroy(particuleCopie, 1f);
        Destroy(gameObject);

        if (infoCollisions.gameObject.tag == "Player")
        {
            soldierControle.estMort = true;
            personnage.GetComponent<Animator>().SetBool("mort", true);
        }


    }

    private void Update()
    {
        Destroy(gameObject, 2f);
    }

}
