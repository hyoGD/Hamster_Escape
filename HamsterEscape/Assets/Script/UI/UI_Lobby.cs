using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class UI_Lobby : MonoBehaviour
{
    public RectTransform lstChain;
    public RectTransform[] listbtuonLeft;  
    // [SerializeField] RectTransform[] listButtonRight;
    [SerializeField] RectTransform[] buttonMain;
    private void OnEnable()
    {
        listbtuonLeft[0].anchoredPosition = new Vector2(-150, -174);
        listbtuonLeft[0].DOAnchorPosX(80, 0.5f).SetEase(Ease.OutBack).SetDelay(0.5f);
        // listButtonRight[0].anchoredPosition = new Vector2(170, -182);
        // listButtonRight[0].DOAnchorPosX(-100, 0.5f).SetEase(Ease.OutBack).SetDelay(0.5f);
       
        lstChain.DOAnchorPos(new Vector2(0f, 76f), 0.5f).SetEase(Ease.OutQuart).SetDelay(0.5f);

        AsyncBaBy();
    }

    async void AsyncBaBy()
    {
        foreach (var button in buttonMain)
        {
           await button.DOAnchorPosY(250, 0.3f).SetEase(Ease.OutBack).AsyncWaitForCompletion();
            
        }
       
    }
    private void OnDisable()
    {
        lstChain.anchoredPosition = new Vector2(938f, 76f);

        for (int i = 0; i < buttonMain.Length; i++)
        {
            buttonMain[i].DOAnchorPosY(-200, 0.1f).SetDelay(0.5f);
        }

    }


}
