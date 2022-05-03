using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MoveChains : MonoBehaviour
{
    public Transform   endRectranform;
    public RectTransform rect;
   // public RectTransform ChainParent;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
       // startPos = transform.position;
       // ChainParent.DOScaleX(0, 0.1f);
       // ChainParent.DOScaleX(1, 1f).SetEase(Ease.OutQuad);
    }

    //private void OnEnable()
    //{
    //    gameObject.GetComponent<RectTransform>().DOAnchorPos(endRectranform.position, 0.5f).SetEase(Ease.OutQuart);
    //  //  rect.DOSizeDelta(new Vector2(696f, 152f), 1f).SetEase(Ease.OutQuart);
    //  //  ChainParent.DOScaleX(1, 1f).SetEase(Ease.OutQuad);
    //}

    //private void OnDisable()
    //{
    //    //  transform.DOMove(startPos, 1f);
    //  //  rect.sizeDelta = new Vector2(0,152f);
    //    gameObject.GetComponent<RectTransform>().DOAnchorPosX(endRectranform.position.x+ 1000 , 0.1f);
    //}   
}
