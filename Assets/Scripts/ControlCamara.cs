using UnityEngine;
using System.Collections;

public class ControlCamara : MonoBehaviour {

    public GameObject seguirObjetivo;
    private Vector3 posObjetivo;
    public float VelocidadMov;

    private static bool ExisteCamara;

	// Use this for initialization
	void Start () {
        
        if (!ExisteCamara)
        {
            ExisteCamara = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        /*posObjetivo = new Vector3(seguirObjetivo.transform.position.x,
                      seguirObjetivo.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, posObjetivo, VelocidadMov * Time.deltaTime);*/
    }
}
