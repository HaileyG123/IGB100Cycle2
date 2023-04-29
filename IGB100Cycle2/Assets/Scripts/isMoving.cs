using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Based upon the discussion and code found in the following link\
//https://answers.unity.com/questions/827119/play-auio-while-object-is-moving.html
public class isMoving : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audio;
    private Rigidbody body;
    private CharacterController charBody;
    private bool audioOn;
    public bool isPlayer;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        if (isPlayer)
        {
            charBody = gameObject.GetComponent<CharacterController>();
        }
        else
        {
            body = GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer)
        {
            if (charBody.velocity.magnitude > 0.1 && !audio.isPlaying)
            {
                audio.Play();
            }
            else if (charBody.velocity.magnitude == 0)
            {
                audio.Stop();
            }
        } else
        {
            if(body.velocity.magnitude > 0.1 && !audio.isPlaying)
            {
                audio.Play();
            } else if (body.velocity.magnitude == 0)
            {
                audio.Stop();
            }
        } 
    }

}
