using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class ClubGenerator : MonoBehaviour {

	/// Take a shot immediately
	void Start () {
		StartCoroutine("SaveJPG");
	}
	
	IEnumerator SaveJPG() {
		WWW w = new WWW("http://urba.org.ar/useruploads/clubes/escudo_10.jpg");
		yield return w;
		byte[] bytes = w.texture.EncodeToJPG();
		Debug.Log("BYTES");
		File.WriteAllBytes(Application.dataPath + "/Fotos/escudo.jpg", bytes);

	}
}
