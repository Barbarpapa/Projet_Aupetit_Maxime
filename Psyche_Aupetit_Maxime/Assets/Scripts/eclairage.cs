using UnityEngine;
using System.Collections;

public class eclairage : MonoBehaviour {

    public bool discoLight = false;
    Light disco;
    bool change = true;
    int timer = 0;
    int random;
    // Use this for initialization
    void Start () {
        disco = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
	    if (discoLight)
        {
            if (timer > 5)
            {
                timer = 0;
                change = true;
            }
            else
            {
                random = Random.Range(0, 3);
                if(random == 0 && change) { disco.color = Color.blue; }
                if (random == 1 && change) { disco.color = Color.red; }
                if (random == 2 && change) { disco.color = Color.green; }
                timer++;
                change = false;
            }
        }
        else
        {
            disco.color = Color.white ;
        }
	}
}
