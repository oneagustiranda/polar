using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingAnimator : MonoBehaviour
{
    public void Show()
    {
        LeanTween.moveLocalY(gameObject, -0.014f, 0.5f).setEaseInExpo();
    }

    public void Hide()
    {
        LeanTween.moveLocalY(gameObject, -1.65f, 0.5f).setEaseInExpo();
    }
}
