using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer1 : MonoBehaviour
{
	public int timeLeft = 90;
	public Text countdownText;

	// Use this for initialization
	void Start()
	{
		StartCoroutine("LoseTime");
	}

	// Update is called once per frame
	void Update()
	{
		countdownText.text = (timeLeft + " Secs" );

		if (timeLeft <= 0)
		{
            FindObjectOfType<GameOverLevelOne>().EndGame();
        }
	}
    //countdown
	IEnumerator LoseTime()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			timeLeft--;
		}
	}
}