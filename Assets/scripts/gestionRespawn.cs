using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestionRespawn : MonoBehaviour
{
    public GameObject[] ennemiXs;
    

    // Update is called once per frame
    void Update()
    {
        if (ennemiXs[0].activeInHierarchy == false)
        {
            Invoke("respawn0", 30f);
        }
        if (ennemiXs[1].activeInHierarchy == false)
        {
            Invoke("respawn1", 30f);
        }
        if (ennemiXs[2].activeInHierarchy == false)
        {
            Invoke("respawn2", 30f);
        }
        if (ennemiXs[3].activeInHierarchy == false)
        {
            Invoke("respawn3", 30f);
        }
        if (ennemiXs[4].activeInHierarchy == false)
        {
            Invoke("respawn4", 30f);
        }
        if (ennemiXs[5].activeInHierarchy == false)
        {
            Invoke("respawn5", 30f);
        }
        if (ennemiXs[6].activeInHierarchy == false)
        {
            Invoke("respawn6", 30f);
        }
        if (ennemiXs[7].activeInHierarchy == false)
        {
            Invoke("respawn7", 30f);
        }
        if (ennemiXs[8].activeInHierarchy == false)
        {
            Invoke("respawn8", 30f);
        }
        if (ennemiXs[9].activeInHierarchy == false)
        {
            Invoke("respawn9", 30f);
        }
        if (ennemiXs[10].activeInHierarchy == false)
        {
            Invoke("respawn10", 30f);
        }
        if (ennemiXs[11].activeInHierarchy == false)
        {
            Invoke("respawn11", 30f);
        }
    }

    void respawn0()
    {
        ennemiXs[0].SetActive(true);
    }
    void respawn1()
    {
        ennemiXs[1].SetActive(true);
    }
    void respawn2()
    {
        ennemiXs[2].SetActive(true);
    }
    void respawn3()
    {
        ennemiXs[3].SetActive(true);
    }
    void respawn4()
    {
        ennemiXs[4].SetActive(true);
    }
    void respawn5()
    {
        ennemiXs[5].SetActive(true);
    }
    void respawn6()
    {
        ennemiXs[6].SetActive(true);
    }
    void respawn7()
    {
        ennemiXs[7].SetActive(true);
    }
    void respawn8()
    {
        ennemiXs[8].SetActive(true);
    }
    void respawn9()
    {
        ennemiXs[9].SetActive(true);
    }
    void respawn10()
    {
        ennemiXs[10].SetActive(true);
    }
    void respawn11()
    {
        ennemiXs[11].SetActive(true);
    }
}
