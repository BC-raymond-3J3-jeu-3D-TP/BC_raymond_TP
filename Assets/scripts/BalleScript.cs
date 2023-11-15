using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BalleScript : MonoBehaviour
{

    public GameObject impactTir; 
    public GameObject personnage;

    public int points;



    private void Update()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision infoCollisions)
    {
        
        GameObject particuleCopie = Instantiate(impactTir);
        particuleCopie.transform.position = infoCollisions.GetContact(0).point;
        particuleCopie.SetActive(true);
        particuleCopie.transform.LookAt(personnage.transform);
        Destroy(particuleCopie, 1f);
        Destroy(gameObject);


        if (infoCollisions.gameObject.tag == "ennemi_Xs")
        {
            infoCollisions.gameObject.SetActive(false);
            points += 1;
            soldierControle.scoreActuel += points;           
        }

        if (infoCollisions.gameObject.tag == "Player")
        {
            soldierControle.estMort = true;
        }


    }



}
