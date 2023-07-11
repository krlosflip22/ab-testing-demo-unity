using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ValuePicker : MonoBehaviour
{
    [Header("Range")]
    [SerializeField] int minValue;
    [SerializeField] int maxValue;

    [Header("Value")]
    [SerializeField] int currentValue;
    [SerializeField] TextMeshProUGUI valueLabel;

    [Header("Buttons")]
    [SerializeField] Button increaseButton;
    [SerializeField] Button decreaseButton;

    private void Awake()
    {
        increaseButton.onClick.AddListener(IncreaseValue);
        decreaseButton.onClick.AddListener(DecreaseValue);

        valueLabel.text = currentValue.ToString();
    }

    public void IncreaseValue() 
    { 
        if(currentValue < maxValue) 
        {
            currentValue++;
            valueLabel.text = currentValue.ToString();
        }
    }

    public void DecreaseValue() 
    {
        if (currentValue > minValue)
        {
            currentValue--;
            valueLabel.text = currentValue.ToString();
        }
    }
}
