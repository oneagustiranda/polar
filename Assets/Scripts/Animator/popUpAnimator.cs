using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUpAnimator : MonoBehaviour
{
    public void SlideUp()
    {
        LeanTween.moveLocalY(gameObject, -530f, 0.5f).setEaseInExpo();
    }

    public void SlideDown()
    {
        LeanTween.moveLocalY(gameObject, -985f, 0.5f).setEaseInExpo();
    }
}
