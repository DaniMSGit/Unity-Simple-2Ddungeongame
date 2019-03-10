using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text textotimer;
    

	// Use this for initialization
	void Start () {

        textotimer.text = GameMaster.tiempo.ToString("f0");
	}
	
	// Update is called once per frame
	void Update () {
        GameMaster.tiempo += Time.deltaTime;
        textotimer.text = GameMaster.tiempo.ToString("f0");
    }
}
