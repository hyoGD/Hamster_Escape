using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DestroyGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnEnable()
    {
        transform.localScale = Vector2.zero;
        transform.DOScale(new Vector2(1, 1), 0.5f).SetEase(Ease.OutBounce).SetDelay(0.1f).OnComplete(()=>
        {
            transform.DOScale(new Vector2(0, 0), 0.5f).SetEase(Ease.InBounce).SetDelay(1f);/*.OnComplete(() =>*/
            //{
            //    Off();
            //});
        });     
    }
    // Update is called once per frame
    void Off()
    {
        Destroy(gameObject,1f);
    }
}
