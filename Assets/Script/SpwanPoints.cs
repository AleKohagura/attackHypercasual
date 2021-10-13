using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanPoints : MonoBehaviour
{
    public GameObject inimigo;
    public int xPos, zPos, inimigoN;
    void Start()
    {
        StartCoroutine(inimigoDrop());
    }

    IEnumerator inimigoDrop()
    {
        while (inimigoN < 15)
        {
            xPos = Random.Range(-8, 8);
            zPos = Random.Range(5, 50);
            Instantiate(inimigo, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(.5f);
            inimigoN += 1;
        }
    }
}
