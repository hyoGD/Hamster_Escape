using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Camfollow : MonoBehaviour
{
   // private Transform player;
    public Vector3 target;
    Vector3 velocity = Vector3.zero;
    float smoothTime = 0.01f;
    private void OnEnable()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 newPosition = MovingPlayer.instance.transform.position + target;
        transform.position = transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
    }
    private void LateUpdate()
    {
        if (MovingPlayer.instance.win && target.x <=3f)
        {
            target.x += 0.05f;
        }
    }
}
