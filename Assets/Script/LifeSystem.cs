using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeSystem : MonoBehaviour
{
    public Slider sliderlife;
    public int min = 0;
    public int max = 100;

    int now;

    void Start()
    {
        if (sliderlife != null)
        {
            sliderlife.minValue = min;
            sliderlife.maxValue = max;
        }

        Altera(max);
    }

    public void Altera(int valor)
    {
        now += valor;
        now = Mathf.Clamp(now, min, max);

        if (sliderlife != null) sliderlife.value = now;
    }

    public int Valor()
    {
        return now;
    }
}
