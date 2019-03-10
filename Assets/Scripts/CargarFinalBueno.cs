using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CargarFinalBueno : MonoBehaviour {

	// Use this for initialization
	void Start () {
	        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.name == "Jugador")
        {
            Destroy(GameObject.Find("Musica"));
            Destroy(GameObject.Find("BandaSonora"));
            GameMaster.Jugador = GameObject.Find("Jugador");
            GameObject.Find("Jugador").SetActive(false);
			GameMaster.highscores.Add(new GameMaster.Score((int)GameMaster.tiempo,GameMaster.nombreJugador));
            SceneManager.LoadScene("FinalBueno");
        }
    }
}
