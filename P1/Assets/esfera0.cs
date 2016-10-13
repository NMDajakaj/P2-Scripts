using UnityEngine;
using System.Collections;

public class esfera0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.active = false;
		GameObject.FindWithTag ("barca").GetComponent<boatScript> ().Evento += metodoEjecutar;
	}
	void metodoEjecutar () {
		this.gameObject.active = true;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
