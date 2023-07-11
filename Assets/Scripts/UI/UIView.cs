using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIView : MonoBehaviour
{
    [SerializeField] protected UIView parent;
    public UIView Parent => parent;

    [SerializeField] protected UIView[] childs;
    
    [SerializeField] bool enableAtInit = false;
    
    public UIView[] Childs 
    { 
        get => childs; 
        set 
        { 
            childs = value;
            if (enableAtInit) enabled = true;
        } 
    }
    void Start()
    {
        foreach(UIView uiv in childs) 
        {
            uiv.parent = this;
        }
    }
}
