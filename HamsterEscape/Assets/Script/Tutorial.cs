using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Tutorial : MonoBehaviour
{
    public bool fistPlay = false;
    public GameObject mess;    
    public float duration;
    string txtMesslv1 = "Press the correct icon to let the Hamster hide behind the objects.Don't get caught.";
    string txtMesslv11 = "Press another icon to keep the Hamster away from the traps.Don't get caught.";
    string txt = "";

    // Start is called before the first frame update
    private void Start()
    {     
        fistPlay = PlayerPrefs.GetInt("Tutorial") == 1;
        if (!fistPlay)
        {
            if (GameController.instance.index == 0)
            {
                this.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-68f, 217f), 1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
                mess.SetActive(true);
                DOTween.To(() => txt, x => txt = x, txtMesslv1, duration).OnUpdate(() => mess.transform.GetChild(0).GetComponent<Text>().text = txt);
            }
            else if (GameController.instance.index == 10)
            {
                this.GetComponent<RectTransform>().anchoredPosition = new Vector2(-424f, 87f);
                this.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-315f, 217f), 1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
                gameObject.SetActive(true);
              //  gameObject.GetComponent<Image>().enabled = false;
                //startPos.DOAnchorPos(endPos.anchoredPosition, 1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
                mess.SetActive(true);
                DOTween.To(() => txt, x => txt = x, txtMesslv11, duration).OnUpdate(() => mess.transform.GetChild(0).GetComponent<Text>().text = txt);
            }
        }
       
    }
    

    public void SetTutorial()
    {
       // mess.SetActive(false);
        gameObject.SetActive(false);
        //fistPlay = true;
        //PlayerPrefs.SetInt("Tutorial", fistPlay ? 1 : 0);
    }

    
}
