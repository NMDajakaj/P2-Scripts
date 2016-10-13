using UnityEngine;
using System.Collections;

public delegate void metodoDelegao ();

public class boatScript : MonoBehaviour {
	public event metodoDelegao Evento;

	void OnTriggerEnter(Collider other) {
		Evento ();
		this.gameObject.SetActive (false);
	}
}
