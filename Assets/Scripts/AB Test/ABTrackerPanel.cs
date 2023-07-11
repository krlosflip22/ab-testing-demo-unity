using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ABTrackerPanel : MonoBehaviour
{
    [SerializeField] GameObject uIBase;

    [SerializeField] Transform spawn;

    [SerializeField] TextMeshProUGUI labelPrefab;

    [SerializeField] GameObject panel;

    List<TextMeshProUGUI> labels;

    ABTracker[] trackers;

    void Start() 
    {
        trackers = uIBase.GetComponentsInChildren<ABTracker>(true);
        labels = new List<TextMeshProUGUI>();
    }

    public void OnClick()
    {   
        for(int i = 0; i < trackers.Length; i++) 
        { 
            if(i >= labels.Count) 
            {
                TextMeshProUGUI label = Instantiate(labelPrefab, spawn);
                label.text = trackers[i].GetTrackValue();
                labels.Add(label);
            }
            else 
            {
                labels[i].text = trackers[i].GetTrackValue();
            }
        }

        panel.SetActive(true);
    }
}
