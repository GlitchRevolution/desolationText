using UnityEngine;
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
	/* Dialogue System = SendMessage(AddLife,,topbar)
	 * Conditional: Variable["VARIABLE_NAME"] == true
	 * [em1]Color Emphasis[/em1]
	 * Item["Assassinate_the_Emperor"].State = "success"
	 * and (Variable["Kills"] < 5)
	 * "I need a doctor, not a [var=My_Job_Title]!"
	 * Variable["Gold"] = Variable["Gold"] + 50
	 */

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
		GUI.DrawTexture(new Rect(75, 4, 25, 25), ammoIcon);
		GUI.Label(new Rect(105, 4, 25, 25), ammoString, skin);
		GUI.color = Color.white;
		GUI.DrawTexture(new Rect(130, 4, 25, 25), knackIcon);
		GUI.Label(new Rect(160, 4, 25, 25), knackString, skin);
	}

	void AddLife() {
		Debug.Log ("+1 Life!");
		life += 1;
	}
	void SubLife(){
		Debug.Log ("-1 Life!");
		life -= 1;
		PixelCrushers.DialogueSystem.DialogueLua.SetVariable("Life", life);
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

	//static void PixelCrushers.DialogueSystem.DialogueLua.SetVariable("Life", life)	
}
