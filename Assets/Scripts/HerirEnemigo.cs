using UnityEngine;
using System.Collections;

public class HerirEnemigo : MonoBehaviour {

    public int dano;
    public GameObject sangre;
    public Transform puntoGolpe;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.tag == "Enemigo1") {
            otro.gameObject.GetComponent<VidaEnemigo>().herirEnemigo(dano);
            Instantiate(sangre,puntoGolpe.position, puntoGolpe.rotation);
        }
    }
}
