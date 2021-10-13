using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class zWeapons : MonoBehaviour
{
    public float delay, maxMuni=10, tempoAtira=0f, currentAmmo = -1, msBetweenShots = 100, fireRate = 15f, impactForce = 30f;

    public GameObject prefab;

    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public AudioSource disparoSom;
    public Camera mainCamera;
    private bool carregando = false;
    public float launchVelocity = 1250*1000000f;
    public Transform gatilho;

    void Start()
    {
        if (currentAmmo == -1)
            currentAmmo = maxMuni;
    }

    // Update is called once per frame
    void Update()
    {
        
        Atirar();
    }

    void Atirar()
    {
        if (carregando)
            return;

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }

        if (Input.GetButtonDown("Fire1")&& Time.time >= tempoAtira)
        {
            tempoAtira = Time.time + 1f / fireRate;
            Bala();
            
        }
    }

    void Bala()
    {
        currentAmmo--;
        GameObject ball = Instantiate(prefab, gatilho.position, gatilho.rotation);

        ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, launchVelocity));

    }

    IEnumerator Reload()
    {
        carregando = true;
        yield return new WaitForSeconds(3);
        currentAmmo = maxMuni;
        carregando = false;
    }
}