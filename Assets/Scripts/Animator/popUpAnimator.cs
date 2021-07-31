using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUpAnimator : MonoBehaviour
{
    public void SlideUp()
    {
        LeanTween.moveY(gameObject.GetComponent<RectTransform>(), 0f, 0.5f).setEaseInExpo();
    }

    public void SlideDown()
    {
        LeanTween.moveY(gameObject.GetComponent<RectTransform>(), -700f, 0.5f).setEaseInExpo();
    }
}
