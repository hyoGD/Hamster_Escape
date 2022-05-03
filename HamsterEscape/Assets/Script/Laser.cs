using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float defDistanceRay = 50;
    public Transform laserFirePoint;
    private LineRenderer m_lineRenderer;
    private Transform m_tranform;
    // Start is called before the first frame update
    void Start()
    {
        m_tranform = GetComponent<Transform>();
        m_lineRenderer = GetComponent<LineRenderer>();
    }
    private void Update()
    {
        shootLaser();
    }
    void shootLaser()
    {
        if(Physics2D.Raycast(m_tranform.position, transform.right))
        {
            RaycastHit2D hit = Physics2D.Raycast(laserFirePoint.position, transform.right);
            Draw2Ray(laserFirePoint.position, hit.point);
        }
        else
        {
            Draw2Ray(laserFirePoint.position, laserFirePoint.transform.right * defDistanceRay);
        }
    }

    void Draw2Ray(Vector2 startPos, Vector2 endPos)
    {
        m_lineRenderer.SetPosition(0, startPos);
        m_lineRenderer.SetPosition(1, endPos);
        
    }
}
