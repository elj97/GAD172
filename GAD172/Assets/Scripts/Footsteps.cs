using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    CharacterController cc;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        if(cc.isGrounded == true && cc.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false)
        {


            //audioSource.volume = Random.Range(0.8f, 1f);
            //audioSource.pitch = Random.Range(0.8f, 1.1f);
            GetComponent<AudioSource>().Play();
        }
    }
}
