using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
	public float PosY = 10.0f;
	public float PosX = 10.0f;

	public float Between = 5.0f;

	private GameObject refObj;

	private GameObject Zero;
	private GameObject One;
	private GameObject Two;
	private GameObject Three;
	private GameObject Four;
	private GameObject Five;
	private GameObject Six;
	private GameObject Seven;
	private GameObject Eight;
	private GameObject Nine;

	private int scoreTemp;

	[System.NonSerialized] public bool deleteFlag = true;

	// Start is called before the first frame update
	void Start()
    {
		refObj = GameObject.Find("Main Camera");

		Zero = (GameObject)Resources.Load("Numeral/Zero");
		One = (GameObject)Resources.Load("Numeral/One");
		Two = (GameObject)Resources.Load("Numeral/Two");
		Three = (GameObject)Resources.Load("Numeral/Three");
		Four = (GameObject)Resources.Load("Numeral/Four");
		Five = (GameObject)Resources.Load("Numeral/Five");
		Six = (GameObject)Resources.Load("Numeral/Six");
		Seven = (GameObject)Resources.Load("Numeral/Seven");
		Eight = (GameObject)Resources.Load("Numeral/Eight");
		Nine = (GameObject)Resources.Load("Numeral/Nine");

		scoreTemp = this.GetComponent<PlayerScript>().score;
	}

    // Update is called once per frame
    void Update()
    {
		// åÖêîåvéZ
		int number = this.GetComponent<PlayerScript>().score;

		int digit = 0;

		while (number > 0)
		{
			number = number / 10;
			digit += 1;
		}

		if (digit == 0)
        {
			digit = 1;
        }

		number = this.GetComponent<PlayerScript>().score;

		if (deleteFlag)
		{
			deleteFlag = false;

			for (int i = 0; i < digit; i++)
			{
				// ç°âÒï\é¶Ç∑ÇÈåÖÇÃêîéö
				int num = (int)(number % 10);

				if (num == 0)
				{
					GameObject cloneNum = Instantiate(Zero, new Vector3(refObj.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
					cloneNum.GetComponent<NumberScript>().pos_x = PosX - i * Between;
				}

				if (num == 1)
				{
					GameObject cloneNum = Instantiate(One, new Vector3(refObj.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
					cloneNum.GetComponent<NumberScript>().pos_x = PosX - i * Between;
				}

				if (num == 2)
				{
					GameObject cloneNum = Instantiate(Two, new Vector3(refObj.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
					cloneNum.GetComponent<NumberScript>().pos_x = PosX - i * Between;
				}

				if (num == 3)
				{
					GameObject cloneNum = Instantiate(Three, new Vector3(refObj.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
					cloneNum.GetComponent<NumberScript>().pos_x = PosX - i * Between;
				}

				if (num == 4)
				{
					GameObject cloneNum = Instantiate(Four, new Vector3(refObj.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
					cloneNum.GetComponent<NumberScript>().pos_x = PosX - i * Between;
				}

				if (num == 5)
				{
					GameObject cloneNum = Instantiate(Five, new Vector3(refObj.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
					cloneNum.GetComponent<NumberScript>().pos_x = PosX - i * Between;
				}

				if (num == 6)
				{
					GameObject cloneNum = Instantiate(Six, new Vector3(refObj.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
					cloneNum.GetComponent<NumberScript>().pos_x = PosX - i * Between;
				}

				if (num == 7)
				{
					GameObject cloneNum = Instantiate(Seven, new Vector3(refObj.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
					cloneNum.GetComponent<NumberScript>().pos_x = PosX - i * Between;
				}

				if (num == 8)
				{
					GameObject cloneNum = Instantiate(Eight, new Vector3(refObj.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
					cloneNum.GetComponent<NumberScript>().pos_x = PosX - i * Between;
				}

				if (num == 9)
				{
					GameObject cloneNum = Instantiate(Nine, new Vector3(refObj.transform.position.x + PosX - i * Between, PosY, 0.0f), Quaternion.identity);
					cloneNum.GetComponent<NumberScript>().pos_x = PosX - i * Between;
				}

				// éüÇÃåÖÇ÷
				number /= 10;
			}
		}

		number = this.GetComponent<PlayerScript>().score;

		if (scoreTemp != number)
		{
			deleteFlag = true;
			scoreTemp = this.GetComponent<PlayerScript>().score;
		}
	}
}
