using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = transform.gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("isOpen", true);
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("isOpen", false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
