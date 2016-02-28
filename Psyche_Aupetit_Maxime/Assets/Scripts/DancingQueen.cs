using UnityEngine;
using System.Collections;

public class DancingQueen : MonoBehaviour {

    Transform rotationCorps;
    Transform rotationDroite;
    Transform rotationGauche;
    bool sens = true;
    int compteur = 0;
    


	// Use this for initialization
	void Start () {
        rotationCorps = GetComponent<Transform>();
        rotationDroite = this.gameObject.transform.GetChild(3);
        rotationGauche = this.gameObject.transform.GetChild(2);
	}
	
	// Update is called once per frame
	void Update () {
        rotationCorps.Rotate(0, 20 * Time.deltaTime, 0);
        if (sens)
        {
            rotationDroite.Rotate(  -80 * Time.deltaTime ,0, 0);
            rotationGauche.Rotate(  -80 * Time.deltaTime, 0, 0);
            compteur++;
        }
        else
        {
            rotationDroite.Rotate( 80 * Time.deltaTime, 0, 0);
            rotationGauche.Rotate( 80 * Time.deltaTime, 0, 0);
            compteur++;
        }
      
            if (compteur == 50)
            {
                if (sens)
                {
                    compteur = 0;
                    sens = false;
                }
                else
                {
                    compteur = 0;
                    sens = true;
                }
            }
        
    }
       
}

