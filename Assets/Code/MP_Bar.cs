using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MP_Bar : MonoBehaviour
{
    [SerializeField] private TMP_Text textDP;
    private Slider _slider;

    private int maxValue;

    public void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void SetUp (int maxvalue)
    {
        this.maxValue = maxvalue;

        _slider.maxValue = maxvalue;

        Setvalue(maxvalue);

    }

    public void Setvalue(int value)
    {
        _slider.value = value;

        textDP.text = value + "/" + maxValue;
    }
}
