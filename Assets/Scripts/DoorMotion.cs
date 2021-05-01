using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{

    private Animator anim;
    public AudioSource open;
    public AudioSource close;

    // Start is called before the first frame update
    void Start()
    {
        anim = transform.gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("isOpen", true);
        open.PlayDelayed(0.7f);
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("isOpen", false);
        close.PlayDelayed(0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
