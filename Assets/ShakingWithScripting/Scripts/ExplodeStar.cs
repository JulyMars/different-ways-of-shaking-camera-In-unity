using UnityEngine;
using System.Collections;

public class ExplodeStar : MonoBehaviour
{
   

    public ParticleSystem explodePartical;
    public CameraShake cameraShake;

   

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            explodePartical.Play();
            StartCoroutine(cameraShake.Shake(0.15f, 0.4f));
        }

    }

}