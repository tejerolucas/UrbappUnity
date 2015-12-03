using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class colorfade : MonoBehaviour {
	public Image imagen;
	public Color[] colores;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			imagen.color=colores[Random.Range(0,colores.Length)];
		}
	}
}
