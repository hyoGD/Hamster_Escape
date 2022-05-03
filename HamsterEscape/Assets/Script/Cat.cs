using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;
using System;
public class Cat : MonoBehaviour
{
    public static Cat instance;
    [Header("SPINE")]
    //  public SkeletonAnimation hamsterSpine;
    public SkeletonAnimation cat;
    [SpineAnimation] public List<string> catAnimation;
   
   
    private void Awake()
    {
        {
            instance = this;
        }
    }

    public void PlayAnimCat(int num, Action anim =null)
    {

        switch (num)
        {
            case 0:
                cat.AnimationState.SetAnimation(0,catAnimation[num], true);
                break;
            case 1:
                cat.AnimationState.SetAnimation(0, catAnimation[num], true);
                break;
            default:
                cat.AnimationState.SetAnimation(0, catAnimation[num], false);
                break;
        }

        //cat.SetAnimation(catAnimation[0], true, () =>
        //{
        //});
    }

    }
