using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalPopUp : MonoBehaviour
{
    public GameObject modal;

    public void Enabled()
    {
        modal.SetActive(true);
    }
    public void Disable()
    {
        modal.SetActive(false);
    }
}
