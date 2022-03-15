using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    GameObject refObj;
    private float playerPosX;
    public float PToCLength = 5.0f;
    private float PtoClengthOriginal;
    private float PtoClengthPlus = 0.05f;
    public float PToCLengthAfter = 1.0f;
    private float PtoClengthAfterOriginal;
    private float PtoClengthAfterback = 0.0f;
    private float PtoClengthAfterPlus = 0.005f;
    private float PtoClengthAfterReturn = 0.1f;
    public float StartLineX = 0.0f;
    public float EndLineX = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");
        playerPosX = 0.0f;
        PtoClengthOriginal = PToCLength;
        PtoClengthAfterOriginal = PToCLengthAfter;
        PToCLengthAfter = 0.0f;
        playerPosX = refObj.GetComponent<Transform>().localPosition.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.transform.localPosition.x >= StartLineX && this.transform.localPosition.x <= EndLineX)
        {
            if (refObj.GetComponent<PlayerStatus>().isRight)
            {
                if (playerPosX < refObj.GetComponent<Transform>().localPosition.x)
                {
                    if (PtoClengthOriginal > PToCLength)
                    {
                        PToCLength += PtoClengthPlus;
                    }

                    if (PtoClengthAfterOriginal > PToCLengthAfter)
                    {
                        PToCLengthAfter += PtoClengthAfterPlus;
                    }

                    PtoClengthAfterback = PToCLengthAfter;

                    playerPosX = refObj.GetComponent<Transform>().localPosition.x;
                }
                else
                {
                    if (0.0f < PToCLengthAfter)
                    {
                        PToCLengthAfter -= PtoClengthAfterReturn * PtoClengthAfterback;
                    }
                }
            }

            if (!refObj.GetComponent<PlayerStatus>().isRight)
            {
                if (playerPosX > refObj.GetComponent<Transform>().localPosition.x)
                {
                    if (-PtoClengthOriginal < PToCLength)
                    {
                        PToCLength -= PtoClengthPlus;
                    }

                    if (-PtoClengthAfterOriginal < PToCLengthAfter)
                    {
                        PToCLengthAfter -= PtoClengthAfterPlus;
                    }

                    PtoClengthAfterback = PToCLengthAfter;

                    if (PtoClengthAfterback < 0.0f)
                    {
                        PtoClengthAfterback *= -1.0f;
                    }

                    playerPosX = refObj.GetComponent<Transform>().localPosition.x;
                }
                else
                {
                    if (0.0f > PToCLengthAfter)
                    {
                        PToCLengthAfter += PtoClengthAfterReturn * PtoClengthAfterback;
                    }
                }
            }
        }
    }

    void Update()
    {
        if (this.transform.localPosition.x >= StartLineX && this.transform.localPosition.x <= EndLineX)
        {
            this.transform.localPosition = new Vector3(PToCLength - PToCLengthAfter + refObj.GetComponent<Transform>().localPosition.x, 0.0f, -10.0f);
        }
        
        if (this.transform.localPosition.x < StartLineX)
        {
            this.transform.localPosition = new Vector3(StartLineX, 0.0f, -10.0f);
        }

        if (this.transform.localPosition.x > EndLineX)
        {
            this.transform.localPosition = new Vector3(EndLineX, 0.0f, -10.0f);
        }
    }
}
