using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{

    private Animator anim;
    public GameObject gameobject;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameobject.GetComponent<Animator>();
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
