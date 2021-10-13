using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bBullet : MonoBehaviour
{
    PJ player;
    public int scorePoint;

    void Start()
    {
        player = GameObject.FindObjectOfType<PJ>();
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyBullet")
        {
            player.UpdateScore(scorePoint);
            Destroy(other.gameObject);

        }
    }
}
