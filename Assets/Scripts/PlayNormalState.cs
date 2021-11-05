using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNormalState : MonoBehaviour
{
    public AudioSource audioSource;
    public float delay = 6f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.PlayDelayed(delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
