using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
//set up chain theo du lieu data.cs
public class Icon : MonoBehaviour
{
    public type t_icon;
    public Image parent, geometry, white;
    public Data data;
    public RectTransform rect;
    public bool opaque, normal = true, isTrue;
    Vector2 Vcurrent;
    // Start is called before the first frame update
   
    void Start()
    {
        parent = GetComponent<Image>();
       // geometry = transform.GetChild(0).GetComponent<Image>();
        if (normal)
        {
            setIcon(t_icon);
        }
        Vcurrent = transform.position;      
    }
    private void OnEnable()
    {
      //  transform.localPosition = new Vector2(-Screen.width, 0);
       // transform.LeanMoveLocalX(Vcurrent, 1f).setEaseInOutExpo().delay = 0.1f;

    }
    // Update is called once per frame
    void Update()
    {

        if (!normal && isTrue)
        {
            setIconTrue(t_icon);
        }
        else if (!normal && !isTrue)
        {
            setIconFaild(t_icon);
        }

    }

    public void setIcon(type t)
    {
        if (opaque)
        {
            parent.sprite = data.ChainColor[0];
        }
        else
        {
            parent.sprite = data.ChainColor[1];
        }
        switch (t)
        {
            case type.tron:
                geometry.sprite = data.chain_Normal[0];
                rect.sizeDelta = new Vector2(68, 68);
                break;
            case type.tamgiac:
                geometry.sprite = data.chain_Normal[1];
                rect.sizeDelta = new Vector2(66, 59);
                //rect.LeanMoveLocalY(5, 0.1f);
                rect.DOLocalMoveY(5, 0.1f);
                break;
            case type.vuong:
                geometry.sprite = data.chain_Normal[2];
                rect.sizeDelta = new Vector2(59, 58);
                break;
        }


    }
    public void setIconTrue(type t)
    {
        Color color = new Color(1, 1, 1, 0);
        white.gameObject.SetActive(true);
        white.DOColor(color, 0.5f);
        parent.sprite = data.ChainColor[2];      
    }
    public void setIconFaild(type t)
    {
        Color color = new Color(1, 1, 1, 0);
        white.gameObject.SetActive(true);
        white.DOColor(color, 0.5f);
        parent.sprite = data.ChainColor[3];
    }
}
