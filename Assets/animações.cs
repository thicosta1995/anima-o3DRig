using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class animações : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Animação();

    }

    public void Animação()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            anim.SetBool("rolarTrue", true);

            anim.SetBool("morreuTrue", false);
            anim.SetBool("corridaTrue", false);
            anim.SetBool("idleFacaTrue", false);
            anim.SetBool("idleArmaTrue", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.SetBool("rolarTrue", false);
            anim.SetBool("morreuTrue", true);
            anim.SetBool("corridaTrue", false);
            anim.SetBool("idleFacaTrue", false);
            anim.SetBool("idleArmaTrue", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            anim.SetBool("rolarTrue", false);
            anim.SetBool("morreuTrue", false);
            anim.SetBool("corridaTrue", true);
            anim.SetBool("idleFacaTrue", false);
            anim.SetBool("idleArmaTrue", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            anim.SetBool("rolarTrue", false);
            anim.SetBool("morreuTrue", false);
            anim.SetBool("corridaTrue", false);
            anim.SetBool("idleFacaTrue", true);
            anim.SetBool("idleArmaTrue", false);

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            anim.SetBool("rolarTrue", false);
            anim.SetBool("morreuTrue", false);
            anim.SetBool("corridaTrue", false);
            anim.SetBool("idleFacaTrue", false);
            anim.SetBool("idleArmaTrue", true);
        }
    }
}
