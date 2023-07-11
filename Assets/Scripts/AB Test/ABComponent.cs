using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UIView))]
public class ABComponent : MonoBehaviour 
{ 
    [Header("A/B Tests")]
    [SerializeField] ABGroup[] viewGroups;
    
    [SerializeField] UIView mainView;

    void Awake() 
    {
        mainView = GetComponent<UIView>();

        mainView.Childs = viewGroups[ABTestManager.TestGroup].testChilds;

        viewGroups[ABTestManager.TestGroup].Initialize();
    }

    [System.Serializable]
    struct ABGroup
    {
        public UIView[] testChilds;

        public GameObject[] testElements;

        public void Initialize()
        {
            foreach (GameObject go in testElements) go.SetActive(true);
        }
    }
}


