using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPoints : MonoBehaviour
{
    PJ player;
    public int scorePoint;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PJ>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            player.UpdateScore(scorePoint);
            Destroy(gameObject);
        }
    }

}