using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeGirlChar : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator.SetInteger("BeeGirlCharState", 0);
    }


    public void NeutralAnimation()
    {
        animator.SetInteger("BeeGirlCharState", 0);
    }
    public void CorrectAnimation()
    {
        animator.SetInteger("BeeGirlCharState", 2);
    }

    public void IncorrectAnimation()
    {
        animator.SetInteger("BeeGirlCharState", 3);
    }

    public void IdleAnimation()
    {
        animator.SetInteger("BeeGirlCharState", 1);
    }

}




