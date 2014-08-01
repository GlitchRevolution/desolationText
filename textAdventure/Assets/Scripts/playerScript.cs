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

	public float playerEXP;
	public float playerStr;
	public float playerInt;
	public float playerAgl;

	//MENU STUFF
	public Transform GUIroot;
	private bool menuOn;
	private bool inventoryOn;
	public Sprite playerPortrait;
	
	//INVENTORY STUFF
	public Sprite item1;
	public string item1text;
	public Sprite item2;
	public string item2text;
	public Sprite item3;
	public string item3text;
	public Sprite item4;
	public string item4text;
	public Sprite item5;
	public string item5text;
	public Sprite item6;
	public string item6text;
	

	/* Dialogue System = SendMessage(AddLife,,topbar)
	 * Conditional: Variable["VARIABLE_NAME"] == true
	 * [em1]Color Emphasis[/em1]
	 * Item["Assassinate_the_Emperor"].State = "success"
	 * and (Variable["Kills"] < 5)
	 * "I need a doctor, not a [var=My_Job_Title]!"
	 * Variable["Gold"] = Variable["Gold"] + 50
	 */


	void Start() {
		GetComponent<SpriteRenderer> ().sprite = playerPortrait; //Player portrait = 
	}
	void Update() {
		lifeString = life.ToString ();
		ammoString = ammo.ToString ();
		knackString = knack.ToString ();
		
		//Move everything over if inventory changes (Could use a better script)
			if (item1 == null){
			item1 = item2;
			item1text = item2text;
			item2 = null;
			item2text = null;
			}
			if (item2 == null){
			item2 = item3;
			item2text = item3text;
			item3 = null;
			item3text = null;
			}
			if (item3 == null){
			item3 = item4;
			item3text = item4text;
			item4 = null;
			item4text = null;
			}
			if (item4 == null){
			item4 = item5;
			item4text = item5text;
			item5 = null;
			item5text = null;
			}
			if (item5 == null){
			item5 = item6;
			item5text = item6text;
			item6 = null;
			item6text = null;
			}
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

		if (menuOn == true) {
		GUI.Label(new Rect(0,50,100,50),"")
		
		if (inventoryOn == true) {
			
		
		}
		}
	}

	void AddLife() {
		life += 1;
		PixelCrushers.DialogueSystem.DialogueLua.SetVariable("Life", life);
	}
	void SubLife(){
		life -= 1;
		PixelCrushers.DialogueSystem.DialogueLua.SetVariable("Life", life);
	}
	void AddAmmo(){
		ammo += 1;
		PixelCrushers.DialogueSystem.DialogueLua.SetVariable("Ammo", ammo);
	}
	void SubAmmo(){
		ammo -= 1;
		PixelCrushers.DialogueSystem.DialogueLua.SetVariable("Ammo", ammo);
	}
	void AddKnack(){
		knack += 1;
		PixelCrushers.DialogueSystem.DialogueLua.SetVariable("Knack", knack);
	}
	void SubKnack(){
		knack -= 1;
		PixelCrushers.DialogueSystem.DialogueLua.SetVariable("Knack", knack);
	}

	void OnMouseDown(){
		if (menuOn == false) {
			GUIroot.active = false;
			Invoke ("menuToggle",0.5f);
		}
		if (menuOn == true) {
			GUIroot.active = true;
			Invoke ("menuToggle",0.5f);
		}
	}
	void menuToggle() {
		menuOn = !menuOn;
	}

	void CharacterCreation(){
		playerStr = GetComponent<CharacterCreation>().strength;
		playerInt = GetComponent<CharacterCreation>().intelligence;
		playerAgl = GetComponent<CharacterCreation>().agility;
		PixelCrushers.DialogueSystem.DialogueLua.SetVariable("Strength", playerStr);
		PixelCrushers.DialogueSystem.DialogueLua.SetVariable("Agility", playerAgl);
		PixelCrushers.DialogueSystem.DialogueLua.SetVariable("Intelligence", playerInt);
		playerPortrait = GetComponent<CharacterCreation> ().portrait;
	}
}
