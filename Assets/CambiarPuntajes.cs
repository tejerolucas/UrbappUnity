using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CambiarPuntajes : MonoBehaviour {
	public Text[] puntos;
		
	public void Refresh () {
		foreach (Text tx in puntos) {
			tx.text=Random.Range(0,45).ToString();
		}
	}
}
