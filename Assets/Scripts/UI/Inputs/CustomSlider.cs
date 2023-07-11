using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustomSlider : Slider
{
    TextMeshProUGUI valueLabel;

    protected override void Awake()
    {
        valueLabel = GetComponentInChildren<TextMeshProUGUI>();

        valueLabel.text = value.ToString();
        
        onValueChanged.AddListener((x) => valueLabel.text = x.ToString());
    }
}
