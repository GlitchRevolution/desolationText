﻿using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	public GUIStyle skin;

	public Texture2D lifeIcon;
	public float life;
	public Texture2D ammoIcon;
	public float ammo;
	public Texture2D knackIcon;
	public float knack;

	private string lifeString;
	private string ammoString;
	private string knackString;

	public Color red;
	public Color yellow;
	//Dialogue System = SendMessage(AddLife,,topbar)

	void Update() {
		lifeString = life.ToString ();
		ammoString = ammo.ToString ();
		knackString = knack.ToString ();
		}

	void OnGUI() {
		GUI.color = red;
		GUI.DrawTexture(new Rect(0, 4, 25, 25), lifeIcon);
		GUI.Label(new Rect(30, 4, 25, 25), lifeString, skin);
		GUI.color = yellow;
		GUI.DrawTexture(new Rect(80, 4, 25, 25), ammoIcon);
		GUI.Label(new Rect(110, 4, 25, 25), ammoString, skin);
		GUI.color = Color.white;
		GUI.DrawTexture(new Rect(160, 4, 25, 25), knackIcon);
		GUI.Label(new Rect(190, 4, 25, 25), knackString, skin);
	}

	void AddLife() {
		Debug.Log ("+1 Life!");
		life += 1;
	}
	void SubLife(){
		Debug.Log ("-1 Life!");
		life -= 1;
	}
	void AddAmmo(){
		ammo += 1;
	}
	void SubAmmo(){
		ammo -= 1;
	}
	void AddKnack(){
		knack += 1;
	}
	void SubKnack(){
		knack -= 1;
	}
}
