using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;
public class Popcorn : MonoBehaviour
{
    public static Popcorn instance;
    [Header("SPINE")]   
    public SkeletonAnimation PopcornAnim;
    [SpineAnimation] public List<string> popcornAnimation;


    private void Awake()
    {
        {
            instance = this;
        }
    }

    public static void PlayAninmation(SkeletonAnimation skAnim, string _strAnim, bool loop)
    {
        if (!skAnim.AnimationName.Equals(_strAnim))
        {

            skAnim.AnimationState.SetAnimation(0, _strAnim, loop);
        }
    }

    public void PlayAnimationPopcorn(int num)
    {
        PlayAninmation(PopcornAnim, popcornAnimation[num], false);
    }

}
