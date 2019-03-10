using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CargarArea : MonoBehaviour {

    public string NivelACargar;
    public Vector3 pos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D otro) {
        if (otro.gameObject.name == "Jugador")
        {
            GameMaster.pos = pos;
            SceneManager.LoadScene(NivelACargar);
        }
    }
}
