using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum Colorr
//{
//    blue,
//    red,
//}
[CreateAssetMenu(fileName = "DataGame", menuName = "Scriptable Objects/ DataGame")]
public class Data : ScriptableObject
{
    [Header("Main")]
    public List<Questions> question= new List<Questions>();
  //  public List<Item> Items = new List<Item>();
    public type[] chainArr;
   // public Colorr color;
    public List<GameObject> itemDeco;
    [Header("Sprite Chuoi bieu tuong")]
    public Sprite[] chain_Normal;
    public Sprite[] ChainColor;
    [Header("Object")]
    public GameObject start, Finish;
    public GameObject[] Obj;
   // public GameObject[] ObjHide;
}
