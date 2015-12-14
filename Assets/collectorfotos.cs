using UnityEngine;
using System.Collections;

public class collectorfotos : MonoBehaviour {
	public string url = "http://urba.org.ar/useruploads/clubes/";
	IEnumerator Start() {
		WWW www = new WWW(url);
		yield return www;

	}
}
