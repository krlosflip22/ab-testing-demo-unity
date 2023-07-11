using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ABTestManager : MonoBehaviour
{
    int testGroup;
    public static int TestGroup => instance.testGroup;

    [SerializeField] TextMeshProUGUI testGroupText;

    static ABTestManager instance;

    public void Awake()
    {
        if(instance != null) 
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;

        testGroup = Random.Range(0, 2);

        testGroupText.text = $"Test Group: {testGroup}";
    }
}
