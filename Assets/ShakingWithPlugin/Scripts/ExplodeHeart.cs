using UnityEngine;
using System.Collections;
using EZCameraShake;

public class ExplodeHeart : MonoBehaviour
{
    
    public ParticleSystem explodePartical;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            explodePartical.Play();
            CameraShaker.Instance.ShakeOnce(4f, 4f, 0.15f, 1f);
        }
    }

   
}