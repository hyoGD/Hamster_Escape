using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;
public class Hamster : MonoBehaviour
{  
    [SerializeField] public SkeletonAnimation hamster;   
    [SpineAnimation] [SerializeField] public string[] animAction;
   
    public static Hamster instance;
    private void Awake()
    {
        instance = this;
    }

    public static void PlayAninmationHamster(SkeletonAnimation skAnim, string _strAnim, bool loop)
    {
        if (!skAnim.AnimationName.Equals(_strAnim))
        {

            skAnim.AnimationState.SetAnimation(0, _strAnim, loop);
        }
    }
    public static void ChangeSkin(SkeletonAnimation skAnim, string ssSkinChange)
    {

        skAnim.Skeleton.SetSkin(ssSkinChange);
    }

    public void PlayAnimHamster(int num)
    {

        switch (num)
        {
            case 0:
                PlayAninmationHamster(hamster, animAction[num], true);
                break;
            case 1:
                PlayAninmationHamster(hamster, animAction[num], true);
                break;
            case 7:
                PlayAninmationHamster(hamster, animAction[num], true);
                break;                
            default:
                PlayAninmationHamster(hamster, animAction[num], false);
                break;
        }
 
    }
}
