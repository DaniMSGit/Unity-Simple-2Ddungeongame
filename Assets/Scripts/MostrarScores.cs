using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MostrarScores : MonoBehaviour {

	public Text scores;
	// Use this for initialization
	void Start () {
		GameMaster.highscores.Sort ();
		string texto = "";
		if (GameMaster.highscores.Count >= 5) {
			List<GameMaster.Score> primerosCinco = new List<GameMaster.Score>();
			primerosCinco = GameMaster.highscores.GetRange (0, 5);
			foreach (GameMaster.Score score in primerosCinco) {
				texto = texto + score.mostrar ();
			}
		} else {
			foreach (GameMaster.Score score in GameMaster.highscores) {
				texto = texto + score.mostrar ();
			}
		}


		scores.text = texto;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
