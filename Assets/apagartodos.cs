using UnityEngine;
using System.Collections;

public class apagartodos : MonoBehaviour {
	public GameObject[] lista;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void seleccionar(int num) {
		foreach(GameObject go in lista){
			go.SetActive(false);
		}
		lista[num].SetActive(true);
	}
}
