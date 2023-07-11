using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIViewTransitions : MonoBehaviour
{
    [SerializeField] RectTransform newView;
    [SerializeField] RectTransform currentView;

    float duration = 0.5f;
    float direction;
    public void SetDirection(int dir) 
    {
        direction = dir;
    }

    public void SetNewView(RectTransform _newView)
    {
        newView = _newView;

        if (direction == 1)
        {
            newView.anchoredPosition = new Vector2(2 * Screen.width, 0);
        }
        else
        { 
            newView.anchoredPosition = new Vector2(0, 0);
        }
    } 
    
    public void SetCurrentView(RectTransform _currentView) 
    {
        if(currentView != null) currentView.gameObject.SetActive(false);

        currentView = _currentView;
        currentView.gameObject.SetActive(true);
        newView.gameObject.SetActive(true);

        Move();
    }

    public void Move()
    {
        if (direction == 1)
        {
            newView.DOMoveX(Screen.width / 2, duration);
        }
        else 
        {
            currentView.DOMoveX(3 * Screen.width / 2, duration);
        }
    }
}
