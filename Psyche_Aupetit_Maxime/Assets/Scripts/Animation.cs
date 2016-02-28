using UnityEngine;
using System.Collections;

public class Animation: MonoBehaviour
{
    Animator anim;
    public Transform mouton;

    public void Start()
    {
    }

    public void OnTriggerEnter(Collider col)
    {
        mouton.GetComponent<Animator>().SetBool("Bouge", true);
    }
}
