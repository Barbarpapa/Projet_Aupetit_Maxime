
using UnityEngine;
using System.Collections;


public class PorteEtSon : MonoBehaviour
{
    int openingTime = 0;
    bool opening = false;
    public Transform pivot;
    public AudioSource inferno;
    public AudioSource voixOff;
    GameObject lightAm;

    public void Start()
    {
        lightAm = GameObject.Find("Directional light");
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
            inferno.Play(150000);
            voixOff.Play();
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (opening == false && openingTime < 91)
        {
            opening = true;
            lightAm.GetComponent<eclairage>().discoLight = true;
        }
    }
   

}

