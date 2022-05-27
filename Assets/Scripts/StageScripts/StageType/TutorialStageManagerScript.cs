using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStageManagerScript : MonoBehaviour
{
    GameObject refObj;
    PlayerScript playerScript;
    GameObject obstacle;
    GameObject juji;
    GameObject cloneJuji;
    GameObject B;
    GameObject cloneB;
    GameObject Y;
    GameObject cloneY;
    GameObject enemy;
    private int tutorialNum = 0;

    private float posX = 0.0f;
    private float tempX = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        playerScript = refObj.GetComponent<PlayerScript>();
        obstacle = (GameObject)Resources.Load("Block_center");
        juji = (GameObject)Resources.Load("juji");
        enemy = (GameObject)Resources.Load("Enemy");
        B = (GameObject)Resources.Load("Bbottun");
        Y = (GameObject)Resources.Load("Ybottun");

        cloneJuji = Instantiate(juji, new Vector3(refObj.transform.position.x, 5.5f, 0.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (cloneJuji)
        {
            cloneJuji.transform.position = new Vector3(refObj.transform.position.x, 5.5f, 0.0f);
            if (tutorialNum > 4) { Destroy(cloneJuji); }
        }

        if (tutorialNum > 4 && !cloneB)
        {
            cloneB = Instantiate(B, new Vector3(refObj.transform.position.x, 5.5f, 0.0f), Quaternion.identity);
        }

        if (cloneB)
        {
            cloneB.transform.position = new Vector3(refObj.transform.position.x, 5.5f, 0.0f);
        }

        if (tutorialNum >= 6 && !cloneY)
        {
            cloneY = Instantiate(Y, new Vector3(refObj.transform.position.x, 5.5f, 0.0f), Quaternion.identity);
        }

        if (cloneY)
        {
            cloneY.transform.position = new Vector3(refObj.transform.position.x, 5.5f, 0.0f);
        }

        if (tutorialNum == 0)
        {
            if (refObj.transform.position.x > posX)
            {
                posX = playerScript.Next5dist;

                GameObject cloneObstacle = Instantiate(obstacle, new Vector3(posX + 5.0f, -2.0f, 0.0f), Quaternion.identity);
                GameObject cloneObstacle2 = Instantiate(obstacle, new Vector3(playerScript.Next4dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

                tutorialNum = 1;
            }
        }

        if (tutorialNum == 1)
        {
            if (refObj.transform.position.x > posX)
            {
                posX = playerScript.Next5dist;

                GameObject cloneObstacle = Instantiate(obstacle, new Vector3(posX + 5.0f, -2.0f, 0.0f), Quaternion.identity);
                GameObject cloneObstacle2 = Instantiate(obstacle, new Vector3(playerScript.Next4dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);

                tutorialNum = 2;
            }
        }

        if (tutorialNum == 2)
        {
            if (refObj.transform.position.x > posX)
            {
                posX = playerScript.Next5dist;

                GameObject cloneObstacle = Instantiate(obstacle, new Vector3(posX + 5.0f, -2.0f, 0.0f), Quaternion.identity);
                GameObject cloneObstacle2 = Instantiate(obstacle, new Vector3(playerScript.Next4dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

                tutorialNum = 3;
            }
        }

        if (tutorialNum == 3)
        {
            if (refObj.transform.position.x > posX)
            {
                posX = playerScript.Next5dist;

                GameObject cloneObstacle = Instantiate(obstacle, new Vector3(posX + 5.0f, -2.0f, 0.0f), Quaternion.identity);
                GameObject cloneObstacle2 = Instantiate(obstacle, new Vector3(playerScript.Next4dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);

                tutorialNum = 4;
            }
        }

        if (tutorialNum == 4)
        {
            if (refObj.transform.position.x > posX)
            {
                posX = playerScript.Next5dist;

                GameObject cloneObstacle = Instantiate(enemy, new Vector3(posX + 5.0f, -2.0f, 0.0f), Quaternion.identity);
                GameObject cloneObstacle2 = Instantiate(enemy, new Vector3(posX + 5.0f, -6.0f, 0.0f), Quaternion.identity);
                GameObject cloneObstacle3 = Instantiate(enemy, new Vector3(posX + 5.0f, 2.0f, 0.0f), Quaternion.identity);

                tutorialNum = 5;
            }
        }

        if (tutorialNum == 5)
        {
            if (refObj.transform.position.x > posX)
            {
                posX = playerScript.Next5dist;

                GameObject cloneObstacle = Instantiate(enemy, new Vector3(posX + 5.0f, -2.0f, 0.0f), Quaternion.identity);
                GameObject cloneObstacle2 = Instantiate(enemy, new Vector3(posX + 5.0f, -6.0f, 0.0f), Quaternion.identity);
                GameObject cloneObstacle3 = Instantiate(enemy, new Vector3(posX + 5.0f, 2.0f, 0.0f), Quaternion.identity);

                tutorialNum = 6;

                tempX = playerScript.Next3dist;
            }
        }

        if (tutorialNum == 6)
        {
            if (refObj.transform.position.x > tempX)
            {
                cloneY.gameObject.SetActive(false);
            }

            if (refObj.transform.position.x > posX)
            {
                posX = playerScript.Next5dist;

                GameObject cloneObstacle = Instantiate(enemy, new Vector3(playerScript.Next4dist + 5.0f, -2.0f, 0.0f), Quaternion.identity);
                GameObject cloneObstacle2 = Instantiate(enemy, new Vector3(playerScript.Next4dist + 5.0f, -6.0f, 0.0f), Quaternion.identity);
                GameObject cloneObstacle3 = Instantiate(enemy, new Vector3(playerScript.Next4dist + 5.0f, 2.0f, 0.0f), Quaternion.identity);

                tutorialNum = 7;

                tempX = playerScript.Next3dist;
                cloneY.gameObject.SetActive(true);
            }
        }

        if (tutorialNum == 7)
        {
            if (refObj.transform.position.x > tempX)
            {
                cloneY.gameObject.SetActive(false);
            }

            if (refObj.transform.position.x > posX)
            {
                posX = playerScript.Next5dist;

                playerScript.goalFlag = true;

                tutorialNum = 8;
            }
        }
    }
}
