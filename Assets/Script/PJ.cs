using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PJ : MonoBehaviour
{
    [SerializeField] private float velocityPJ;

    public float speed;

    public Text scoreText;

    int zScore = 0;
    public AudioClip shootSound;


    LifeSystem lifeS;

    //public static PJ Instance { get; set; }
    public int munitionB;
    public Transform target;

    void Start()
    {
        lifeS = GetComponent<LifeSystem>();
    }

    void Update()
    {
      //  Move();
        Death();
    }

    public void UpdateScore(int points)
    {
        zScore += points;
        scoreText.text = "Pontos: " + zScore;

    }
    private void Move()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a, b, speed/200f);
    }

    void Death()
    {
        if (lifeS.Valor() <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        }

    }

    void Atira()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (munitionB > 0)
            {
                munitionB--;
            }
        }
    }

    public GameObject pickEffect;

    void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
        if (other.CompareTag("EnemyBullet"))
        {
            lifeS.Altera(-25);
            Destroy(other.gameObject);
        }


        if (other.CompareTag("Espin"))
        {
            lifeS.Altera(-20);
        }

        if (other.CompareTag("Fim"))
        {
            SceneManager.LoadScene("Fim");
        }

    }
}
