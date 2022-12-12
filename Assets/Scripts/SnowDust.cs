using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowDust : MonoBehaviour
{

    [SerializeField]ParticleSystem particleSystem;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Ground")
        {
            particleSystem.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D target)
    {
        if (target.gameObject.tag=="Ground")
        {
            particleSystem.Stop();

        }
    }


}
