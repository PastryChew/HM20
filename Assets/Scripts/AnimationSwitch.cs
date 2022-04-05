using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{

    public Animator anim;
   


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SwitchAnim()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.SetInteger("NumberOfAnim", 1);
        }
         if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.SetInteger("NumberOfAnim", 2);
        }
         if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            anim.SetInteger("NumberOfAnim", 3);
        }
         if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            anim.SetInteger("NumberOfAnim", 4);
        }
         if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            anim.SetInteger("NumberOfAnim", 0);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        SwitchAnim();
    }
}
