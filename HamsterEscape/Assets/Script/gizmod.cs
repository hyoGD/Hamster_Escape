using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gizmod : MonoBehaviour
{
    public Color color = new Color(1, .092F, .016F, .5F);
    private BoxCollider2D box2D;
   // public float boxLength, boxHeight;

    private void Awake()
    {
        
    }
    private void OnDrawGizmos()
    {
        box2D = GetComponent<BoxCollider2D>();
        Gizmos.color = color;
        Gizmos.DrawCube(box2D.bounds.center, new Vector2(box2D.size.x, box2D.size.y));
    }
}