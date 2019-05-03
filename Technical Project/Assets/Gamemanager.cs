using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour {
	enum elements {cockroach = 1 , foot = 2, bomb = 3}

	private int playerChoose = -1;
	private int botChoose = -1;

	private bool playerTurn = true;

	public GameObject WinnerText;

	public Sprite cockroachImage, bombImage, footImage, Winner, Loser,Draw;
	public GameObject botChooseImage;
	public GameObject WLImage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerTurn && playerChoose == -1)
			return;
		else {
			BotChoose ();
			CheckWinner ();
			playerChoose = -1;
			playerTurn = true;
		}
			

	}
	void CheckWinner() {
		if (playerChoose == botChoose) {
			//draw
			WinnerText.GetComponent<Text> ().text = "Draw";
			WLImage.GetComponent<Image>().sprite = Draw;
		} else if (playerChoose == (int)elements.cockroach && botChoose == (int)elements.bomb) {
			//player wins
			WinnerText.GetComponent<Text> ().text = "Player won!";
			WLImage.GetComponent<Image>().sprite = Winner;
		} else if (playerChoose == (int)elements.bomb && botChoose == (int)elements.cockroach) {
			//bot wins
			WLImage.GetComponent<Image>().sprite = Loser;
			WinnerText.GetComponent<Text> ().text = "AI won!";
		} else if (playerChoose == (int)elements.foot && botChoose == (int)elements.bomb) {
			//bot wins
			WinnerText.GetComponent<Text> ().text = "AI won!";
			WLImage.GetComponent<Image>().sprite = Loser;

		} else if (playerChoose == (int)elements.bomb && botChoose == (int)elements.foot) {
			//player wins
			WLImage.GetComponent<Image>().sprite = Winner;
			WinnerText.GetComponent<Text> ().text = "Player won!";
		} else if (playerChoose == (int)elements.foot && botChoose == (int)elements.cockroach) {
			//plyer wins
			WLImage.GetComponent<Image>().sprite = Winner;
			WinnerText.GetComponent<Text> ().text = "Player won!";
		}else if (playerChoose == (int)elements.cockroach && botChoose == (int)elements.foot) {
			//bot wins
			WinnerText.GetComponent<Text> ().text = "AI won!";
			WLImage.GetComponent<Image>().sprite = Loser;
		}

	}

	public void PlayerChoose(int choose) {
		playerChoose = choose;
		playerTurn = false; // makes it bot turn

		
	}
	public void BotChoose() {
		botChoose = Random.Range (1, 4); // random number generator
		if (botChoose == 1) {
			botChooseImage.GetComponent<Image>().sprite = cockroachImage;
		} else if(botChoose == 3) {
			botChooseImage.GetComponent<Image>().sprite = footImage;
		}
		else {
			botChooseImage.GetComponent<Image>().sprite = bombImage;
		}


	}
	void OnClickEvent ()

	{

		Screen.fullScreen = true;

	}

}
