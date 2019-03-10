using UnityEngine;
using System.Collections;

public class PosicionPartidaJugador : MonoBehaviour {

    private ControlJugador jugador;
    private ControlCamara  camara;

    public Vector2 direccionPartida;

	// Use this for initialization
	void Start () {

        jugador = FindObjectOfType<ControlJugador>();


        jugador.transform.position = GameMaster.pos;
        jugador.ultimoMov = direccionPartida;

        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
