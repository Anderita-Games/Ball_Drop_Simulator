using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	float height;
	float width;

	void Start () {
		height = Camera.main.orthographicSize * 2.0f;
		width = height * Screen.width / Screen.height;
	}

	void Update () {
		if (this.transform.position.y <= -4) {
			if (this.transform.position.x <= 0 - (width / 2) + (width / 10)) {
				GameObject.Find("Canvas").GetComponent<GameMaster>().Score += 5;
			}else if (this.transform.position.x <= 0 - (width / 2f) + (width * .2f)) {
				GameObject.Find("Canvas").GetComponent<GameMaster>().Balls_Left -= 1;
			}else if (this.transform.position.x <= 0 - (width / 2f) + (width * .3f)) {
				GameObject.Find("Canvas").GetComponent<GameMaster>().Score += 50;
			}else if (this.transform.position.x <= 0 - (width / 2f) + (width * .4f)) {
				GameObject.Find("Canvas").GetComponent<GameMaster>().Score += 10;
			}else if (this.transform.position.x <= 0 - (width / 2f) + (width * .5f)) {
				GameObject.Find("Canvas").GetComponent<GameMaster>().Score += 25;
			}else if (this.transform.position.x <= 0 - (width / 2f) + (width * .6f)) {
				GameObject.Find("Canvas").GetComponent<GameMaster>().Score += 25;
			}else if (this.transform.position.x <= 0 - (width / 2f) + (width * .7f)) {
				GameObject.Find("Canvas").GetComponent<GameMaster>().Score += 10;
			}else if (this.transform.position.x <= 0 - (width / 2f) + (width * .8f)) {
				GameObject.Find("Canvas").GetComponent<GameMaster>().Score += 50;
			}else if (this.transform.position.x <= 0 - (width / 2f) + (width * .9f)) {
				GameObject.Find("Canvas").GetComponent<GameMaster>().Balls_Left -= 1;
			}else if (this.transform.position.x <= 0 - (width / 2f) + (width)) {
				GameObject.Find("Canvas").GetComponent<GameMaster>().Score += 5;
			}
			Destroy(this);
		}
	}
}
