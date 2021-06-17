using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingAnim : MonoBehaviour
{
    private Animator Anim;
    public bool isEnabled = true;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimUp()
    {
        isEnabled = !isEnabled;

       if (isEnabled == true)
        {
            Anim.Play("BuildingAnim", -1, 0f);
            Anim.speed = 1f;
        }
        else
        {
            Anim.Play("BuildingHide", -1, 0f);
        }


            // Renderer rend = gameObject.GetComponent<Renderer>();

            // if (rend.enabled){
            //     rend.enabled = false;
            // }
            // else{
            //     rend.enabled = true;
            // }
                
    }

}
