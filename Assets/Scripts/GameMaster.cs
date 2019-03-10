using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class GameMaster : MonoBehaviour {

	public class Score : System.IComparable {
		public int score;
		public string playerName;

		public Score(int score, string playerName) {
			this.score = score;
			this.playerName = playerName;
		}

		public int CompareTo(object obj) {
			Score otherScore = obj as Score;
			if(otherScore!=null) {
				return this.score.CompareTo(otherScore.score);
			} else {
				throw new System.ArgumentException("Object is not a Score");
			}
		}

		public System.String mostrar() {
			return score + "seg" + "  " + playerName + "\n";
		}



	}

    public static Vector3 pos;
    public static int VidaJugador  = 100;
    public static int VidaEnemigo  = 20;
    public static float tiempo = 0;
    public static bool sonido = false;
    public static float volumen = 1;
	public static List<Score> highscores = new List<Score>();
	public static string nombreJugador;

    public static GameObject Jugador;

    void Start() {

		nombreJugador = "";
        int tmp = PlayerPrefs.GetInt("sonido", 0);
        if (tmp == 0) sonido = false;
        else sonido = true;

        volumen = PlayerPrefs.GetFloat("volumen", 1);

		string scores;
		scores = PlayerPrefs.GetString ("puntuaciones");

		if (scores != "") {
			string[] palabras = scores.Split('*');
			for (int i = 0; i < palabras.Length - 1; i+=2) {
				highscores.Add(new Score(System.Convert.ToInt32(palabras[i]),palabras[i+1]));
			}
		}

        pos = new Vector3(-0.35f, -1.13f, 0f);
        DontDestroyOnLoad(this);
       
             
    }


    void Awake()
    {
        DontDestroyOnLoad(this);
        
    }

    void OnApplicationQuit()
    {

        if (sonido == false) PlayerPrefs.SetInt("sonido", 0);
        else PlayerPrefs.SetInt("sonido", 1);

        PlayerPrefs.SetFloat("volumen", volumen);

		string scores = "";

		foreach (Score score in highscores) {
			scores = scores + score.score + "*" + score.playerName +"*";
		}

		PlayerPrefs.SetString ("puntuaciones", scores);
    }


}
