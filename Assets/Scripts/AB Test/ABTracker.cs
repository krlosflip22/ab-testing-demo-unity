using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABTracker : MonoBehaviour
{
    [SerializeField] string trackerCode;


    public void Track()
    {
        int trackerValue = PlayerPrefs.GetInt(trackerCode, 0);

        trackerValue++;
        PlayerPrefs.SetInt(trackerCode, trackerValue);
        PlayerPrefs.Save();
    }

    public string GetTrackValue() => $"{trackerCode}: {PlayerPrefs.GetInt(trackerCode, 0)}";
}
