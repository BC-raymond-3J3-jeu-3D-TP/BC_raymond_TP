using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class soldierControle : MonoBehaviour
{

    public float vitesseDeplacement;
    Rigidbody rigidbodySoldier;
    Animator animSoldier;
    public GameObject cameraSuivi;
    bool auSol;
    public float hauteurSaut;
    float forceSaut;
    public float ajoutGravite;
    public static int scoreActuel;
    int scoreReel;
    public TMP_Text scoreText;
    public TMP_Text mortText;
    public static bool estMort;

    private void Start()
    {
        rigidbodySoldier = GetComponent<Rigidbody>();
        animSoldier = GetComponent<Animator>();
        estMort = false;
    }

    private void Update()
    {
        RaycastHit grounded;
        bool auSol = Physics.SphereCast(transform.position + new Vector3(0f, 0.5f, 0f), 0.2f, Vector3.down, out grounded, 0.8f);
        if (!estMort)
        {
            GetComponent<Animator>().SetBool("saut", !auSol);
            float forceH = Input.GetAxisRaw("Horizontal");
            float forceV = Input.GetAxisRaw("Vertical");

            Vector3 orientation = cameraSuivi.transform.forward * forceV + cameraSuivi.transform.right * forceH;

            orientation.y = 0;

            if (orientation != Vector3.zero)
            {
                transform.forward = orientation;
                rigidbodySoldier.velocity = (transform.forward * vitesseDeplacement) + new Vector3(0, rigidbodySoldier.velocity.y, 0);
            }


            else
            {
                rigidbodySoldier.velocity = new Vector3(0, rigidbodySoldier.velocity.y, 0);
                animSoldier.SetFloat("vitesse", rigidbodySoldier.velocity.magnitude);
            }



            if (Input.GetKeyDown(KeyCode.Space) && auSol)
            {
                forceSaut = hauteurSaut;
            }

            if (scoreActuel != scoreReel)
            {
                scoreReel = scoreActuel;
                scoreText.text = "score :" + scoreReel.ToString();
            }
        }
        if (estMort)
        {
            mortText.gameObject.SetActive(true);
        }
        //TournePersonnage();
    }

    void FixedUpdate()
    {
        if (!auSol)
        {
            GetComponent<Rigidbody>().AddRelativeForce(0f, forceSaut, 0f, ForceMode.VelocityChange);
        }
        else
        {
            GetComponent<Rigidbody>().AddRelativeForce(0f, ajoutGravite, 0f, ForceMode.VelocityChange);
        }

        GetComponent<Animator>().SetFloat("vitesse", rigidbodySoldier.velocity.magnitude);
        forceSaut = 0f;

    }

    public void Recommencer()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    /*void TournePersonnage()
    {
        Ray camRay = Camera.current.ScreenPointToRay(Input.mousePosition);

        RaycastHit infoCollision;


        if (Physics.Raycast(camRay.origin, camRay.direction, out infoCollision, 5000, LayerMask.GetMask("plancher")))
        {

            transform.LookAt(infoCollision.point);

            Vector3 rotationActuelle = transform.localEulerAngles;
            rotationActuelle.x = 0f;
            rotationActuelle.z = 0f;
            transform.localEulerAngles = rotationActuelle;
        }
        Debug.DrawRay(camRay.origin, camRay.direction * 100, Color.yellow);
    }*/

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "trappe")
        {
            collision.gameObject.SetActive(false);
        }
        
        
        if (collision.gameObject.tag == "safety")
        {
            estMort = true;
            GetComponent<Animator>().SetBool("mort", true);
        }
    }
}
