using UnityEngine;
using System.Collections;
using System.IO;

public class CrearClubes : MonoBehaviour {
	public Transform padre;
	public GameObject club;
	void Start () {
		string[] lineas=Directory.GetFiles(Application.dataPath+"/Equipos");

		foreach(string st in lineas){
			if(st.Contains(".meta")){
				GameObject go= Instantiate(club)as GameObject;
				go.transform.SetParent(padre);
				ClubPropieties clubp=go.GetComponent<ClubPropieties>();
				string ass=Path.GetFileName(st);
				clubp.nombre.text=ass.Remove((ass.Length-5),5);
			}
		}
	}

}
