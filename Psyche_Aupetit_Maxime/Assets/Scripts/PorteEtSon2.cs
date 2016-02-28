
using UnityEngine;
using System.Collections;


public class PorteEtSon2 : MonoBehaviour
{
    int openingTime = 0;
    bool opening = false;
    public Transform pivot;
    public AudioSource inferno;
    public AudioSource jaws;
    GameObject mouton;
    GameObject lightAm2;

    public void Start()
    {
        mouton = GameObject.Find("Agent");
        lightAm2 = GameObject.Find("Directional light");
    }

    public void Update()
    {
        if (openingTime >= 90)
        {
            opening = false;
        }
        if (opening == true)
        {
            openingTime = openingTime + 5;
            pivot.Rotate(0, 5, 0);
            inferno.Stop();
            jaws.Play();
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (opening == false && openingTime < 91)
        {
            opening = true;
            lightAm2.GetComponent<eclairage>().discoLight = false;
            mouton.GetComponent<Follower>().hasTarget = true;    
        }
    }


}
