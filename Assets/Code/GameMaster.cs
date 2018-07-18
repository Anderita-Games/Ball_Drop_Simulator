using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {
	public UnityEngine.UI.Text Balls_Text;
	public UnityEngine.UI.Text Score_Text;

	public GameObject Peg;
	public GameObject Ball;
	public GameObject Divider;

	public int Balls_Left = 7;
	public int Score = 0;

	float Thickness = .1f;

	void Start () {
		float height = Camera.main.orthographicSize * 2.0f;
		float width = height * Screen.width / Screen.height;

		for (int a = 0; a < 14 ; a++) {
			for (int b = 0; b < 12; b++) {
				GameObject Clone = Instantiate(Peg);
				Clone.transform.position = new Vector2((a / 2f) - 3.25f, (b / 2f) - 3);
				if (b % 2 == 0) {
					Clone.transform.position = new Vector2((a / 2f) - 3.5f, (b / 2f) - 3);
				}
			}
		}

		GameObject Clones = Instantiate(Divider);
		Clones.transform.localScale = new Vector3(Thickness, height, 1);
		Clones.transform.position = new Vector2(0 - (width / 2f) + (Thickness / 2f), 0);
		Clones = Instantiate(Divider);
		Clones.transform.localScale = new Vector3(Thickness, height, 1);
		Clones.transform.position = new Vector2(width / 2f - (Thickness / 2f), 0);
		Clones = Instantiate(Divider);
		Clones.transform.localScale = new Vector3(width, Thickness, 1);
		Clones.transform.position = new Vector2(0, 0 - (height / 2f) + (Thickness / 2f));
		Clones = Instantiate(Divider);
		Clones.transform.localScale = new Vector3(width, Thickness, 1);
		Clones.transform.position = new Vector2(0, height / 2f - (Thickness / 2f));
		int Tallness = 1;
		for (int i = 0; i < 10; i++) {
			Clones = Instantiate(Divider);
			Clones.transform.localScale = new Vector3(Thickness, Tallness, 1);
			Clones.transform.position = new Vector2(0 - (width / 2f) + (width / 10 * i), 0 - (height / 2f) + (Tallness / 2f));
		}
	}

	void Update () {
		Balls_Text.text = "Balls: " + Balls_Left;
		Score_Text.text = "Score: " + Score;

		if (Input.GetMouseButtonDown(0)) {
			if (Balls_Left > 0 && Input.mousePosition.y >= 700) {
				Debug.Log(Input.mousePosition.y);
				GameObject Clone = Instantiate(Ball);
				Vector3 Mouse_Position = Input.mousePosition;
				Mouse_Position.z = 0;
				Clone.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Mouse_Position).x, Camera.main.ScreenToWorldPoint(Mouse_Position).y, 0);
				Balls_Left--;
			}else {
				SceneManager.LoadScene("Game");
			}
		}

		if (Balls_Left < 0) {
			Balls_Left = 0;
		}
	}
}
