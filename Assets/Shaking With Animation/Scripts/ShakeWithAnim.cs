using UnityEngine;
using System.Collections;

public class ShakeWithAnim : MonoBehaviour
{
   

    public Animator camAnim;
    public ParticleSystem explodeStar;

   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            camAnim.SetTrigger("Shake");
            explodeStar.Play();
        }
    }

   
}