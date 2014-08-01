using UnityEngine;
using System.Collections;

public class inventoryMenu : MonoBehaviour {

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
	
	public Sprite itemHold;
	public string itemHoldText;
	

	void Update() {
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
	
	void ItemChange(){
			if (item1 == null){
			item1 = itemHold;
			item1text = itemHoldText;
			itemHold = null;
			itemHoldText = null;
		}
			if (item2 == null){
			item2 = itemHold;
			item2text = itemHoldText;
			itemHold = null;
			itemHoldText = null;
		}
			if (item3 == null){
			item3 = itemHold;
			item3text = itemHoldText;
			itemHold = null;
			itemHoldText = null;
		}
			if (item4 == null){
			item4 = itemHold;
			item4text = itemHoldText;
			itemHold = null;
			itemHoldText = null;
		}
			if (item5 == null){
			item5 = itemHold;
			item5text = itemHoldText;
			itemHold = null;
			itemHoldText = null;
		}
			if (item6 == null){
			item6 = itemHold;
			item6text = itemHoldText;
			itemHold = null;
			itemHoldText = null;
		}
	}


}
