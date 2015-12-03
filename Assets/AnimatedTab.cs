using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimatedTab : MonoBehaviour {
	public Image barra;
	private Vector2 barrapos;
	public Color col;

	void Start(){
		LayoutElement[] gos = this.transform.GetComponentsInChildren<LayoutElement> ();
		foreach (LayoutElement lay in gos) {
			//lay.flexibleWidth=-1;
			Debug.Log("asd");
		}
	}

	public void Mover (GameObject go) {
		barrapos = barra.rectTransform.anchoredPosition;
		col = go.GetComponentInChildren<Text> ().color;
		iTween.ValueTo (this.gameObject, iTween.Hash ("time",0.3f,"easetype",iTween.EaseType.easeInCubic,"to",go.GetComponent<RectTransform>().anchoredPosition.x,"from",barrapos.x,"onupdatetarget",this.gameObject,"onupdate","refresh"));
	}

	void Update(){
		barra.color = Color.Lerp(barra.color, col,0.05f);
	}
	
	// Update is called once per frame
	void refresh (float valor) {
		barra.rectTransform.anchoredPosition = new Vector2 (valor, barrapos.y);
	}
}
