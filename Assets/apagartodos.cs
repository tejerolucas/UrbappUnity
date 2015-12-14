using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class apagartodos : MonoBehaviour {
	public ScrollRect scr;
	public GameObject[] lista;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void seleccionar(int num) {
		foreach(GameObject go in lista){
			go.SetActive(false);
		}
		scr.content = lista [num].GetComponent<RectTransform>();
		lista[num].SetActive(true);
	}
}
