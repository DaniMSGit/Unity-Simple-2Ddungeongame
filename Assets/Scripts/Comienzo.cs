using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Comienzo : MonoBehaviour {

	public InputField EntradaTexto;

	// Use this for initialization
	public void Cargar () {

        


		if (GameMaster.Jugador != null && GameMaster.nombreJugador.Length == 3) {
			GameMaster.VidaJugador = 100;
			GameMaster.tiempo = 0;
			GameMaster.Jugador.SetActive (true);
			GameMaster.Jugador.GetComponent<ControlJugador> ().resetear ();
			SceneManager.LoadScene ("pantalla1");
		} else if(GameMaster.nombreJugador.Length == 3) {
			SceneManager.LoadScene ("pantalla1");
		}




    }

	public void GuardarNombre(){
	
		GameMaster.nombreJugador = EntradaTexto.text;
	}
	
}
