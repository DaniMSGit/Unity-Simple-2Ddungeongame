using UnityEngine;
using System.Collections;

public class HerirJugador : MonoBehaviour {

    public int valordano;
	public AudioSource danojugador;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D otro)
    {
        if (otro.gameObject.name == "Jugador")
        {

            otro.gameObject.GetComponent<VidaJugador>().herirJugador(valordano);
			danojugador.Play ();
        }
    }
}
