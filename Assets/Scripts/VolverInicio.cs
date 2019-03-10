using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class VolverInicio : MonoBehaviour
{

    public void Cargar()
    {
		GameMaster.nombreJugador = "";
        SceneManager.LoadScene("principal");
    }

}