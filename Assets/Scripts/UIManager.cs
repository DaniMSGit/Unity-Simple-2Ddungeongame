using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Slider barraDeVida;
    public Text numeroVida;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        barraDeVida.maxValue = 100;
        barraDeVida.value = GameMaster.VidaJugador;
        numeroVida.text = "Vida: "  + GameMaster.VidaJugador;
	}
}
