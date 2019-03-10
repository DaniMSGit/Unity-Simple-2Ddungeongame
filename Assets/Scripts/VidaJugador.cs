using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class VidaJugador : MonoBehaviour {


   
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if (GameMaster.VidaJugador <= 0)
        {
            Destroy(GameObject.Find("Musica"));
            Destroy(GameObject.Find("BandaSonora"));
            GameMaster.Jugador = GameObject.Find("Jugador");
            gameObject.SetActive(false);
            SceneManager.LoadScene("FinalMalo");
        }
     
	}

    public void herirJugador(int valor)
    {
        GameMaster.VidaJugador -= valor;
    }

    public void Curar()
    {
        GameMaster.VidaJugador = 100;
        
    }

}
