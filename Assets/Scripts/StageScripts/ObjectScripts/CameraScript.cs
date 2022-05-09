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
    private float CameraWidth;

    private GameObject bar;
    private GameObject barUpper;
    private GameObject barBack;
    public float barSpaceX = -13.5f;
    public float barSpaceY = 8.7f;
    private int HP;
    private float barScale;

    //private static int ONPU_MAX = 10;
    //GameObject[] cloneOnpu = new GameObject[ONPU_MAX];
    //private float onpuSpaceX = 2.0f;
    //private float onpuSpaceY = 1.0f;
    //private float onpuToOnpuSpace = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        refObj = GameObject.Find("Player");

        HP = refObj.GetComponent<PlayerScript>().HP;

        playerPosX = 0.0f;
        PtoClengthOriginal = PToCLength;
        PtoClengthAfterOriginal = PToCLengthAfter;
        PToCLengthAfter = 0.0f;
        playerPosX = refObj.GetComponent<Transform>().localPosition.x;
        CameraWidth = this.GetComponent<Camera>().orthographicSize * (16.0f / 9.0f); // アスペクト比が16:9のとき
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (this.transform.localPosition.x >= StartLineX + CameraWidth && this.transform.localPosition.x <= EndLineX - CameraWidth)
        //{
        //    if (refObj.GetComponent<PlayerStatus>().isRight)
        //    {
        //        if (playerPosX < refObj.GetComponent<Transform>().localPosition.x)
        //        {
        //            if (PtoClengthOriginal > PToCLength)
        //            {
        //                PToCLength += PtoClengthPlus;
        //            }

        //            if (PtoClengthAfterOriginal > PToCLengthAfter)
        //            {
        //                PToCLengthAfter += PtoClengthAfterPlus;
        //            }

        //            PtoClengthAfterback = PToCLengthAfter;

        //            playerPosX = refObj.GetComponent<Transform>().localPosition.x;
        //        }
        //        else
        //        {
        //            if (0.0f < PToCLengthAfter)
        //            {
        //                PToCLengthAfter -= PtoClengthAfterReturn * PtoClengthAfterback;
        //            }
        //        }
        //    }

        //    if (!refObj.GetComponent<PlayerStatus>().isRight)
        //    {
        //        if (playerPosX > refObj.GetComponent<Transform>().localPosition.x)
        //        {
        //            if (-PtoClengthOriginal < PToCLength)
        //            {
        //                PToCLength -= PtoClengthPlus;
        //            }

        //            if (-PtoClengthAfterOriginal < PToCLengthAfter)
        //            {
        //                PToCLengthAfter -= PtoClengthAfterPlus;
        //            }

        //            PtoClengthAfterback = PToCLengthAfter;

        //            if (PtoClengthAfterback < 0.0f)
        //            {
        //                PtoClengthAfterback *= -1.0f;
        //            }

        //            playerPosX = refObj.GetComponent<Transform>().localPosition.x;
        //        }
        //        else
        //        {
        //            if (0.0f > PToCLengthAfter)
        //            {
        //                PToCLengthAfter += PtoClengthAfterReturn * PtoClengthAfterback;
        //            }
        //        }
        //    }
        //}
    }

    void Update()
    {
        if (this.transform.localPosition.x >= StartLineX + CameraWidth && this.transform.localPosition.x <= EndLineX - CameraWidth + 1)
        {
            this.transform.localPosition = new Vector3(PToCLength - PToCLengthAfter + refObj.GetComponent<Transform>().localPosition.x, 0.0f, this.transform.localPosition.z);
        }
        
        if (this.transform.localPosition.x < StartLineX + CameraWidth)
        {
            this.transform.localPosition = new Vector3(StartLineX + CameraWidth, 0.0f, this.transform.localPosition.z);
        }

        if (this.transform.localPosition.x > EndLineX - CameraWidth)
        {
            this.transform.localPosition = new Vector3(EndLineX - CameraWidth, 0.0f, this.transform.localPosition.z);
        }

        // HPバーの生成
        if (bar == null)
        {
            GameObject BarR = (GameObject)Resources.Load("Bar");
            bar = Instantiate(BarR, this.transform.position + new Vector3(barSpaceX + this.transform.position.x, barSpaceY + this.transform.position.y, 0.0f), Quaternion.identity);
        }

        if (barUpper == null)
        {
            GameObject BarUpperR = (GameObject)Resources.Load("BarUpper");
            barUpper = Instantiate(BarUpperR, new Vector3(barSpaceX + this.transform.position.x, barSpaceY + this.transform.position.y, 0.0f), Quaternion.identity);
            barScale = barUpper.transform.localScale.x;
        }

        if(barBack == null)
        {
            GameObject BarBackR = (GameObject)Resources.Load("BarBack");
            barBack = Instantiate(BarBackR, this.transform.position + new Vector3(barSpaceX + this.transform.position.x, barSpaceY + this.transform.position.y, 0.0f), Quaternion.identity);
        }

        bar.transform.position = new Vector3(barSpaceX + this.transform.position.x, barSpaceY + this.transform.position.y, 0.0f);
        barBack.transform.position = new Vector3(barSpaceX + this.transform.position.x, barSpaceY + this.transform.position.y, 0.0f);

        float tempX = (barScale / HP) * refObj.GetComponent<PlayerScript>().HP;
        float tempXupper = (barScale - (barScale / HP) * refObj.GetComponent<PlayerScript>().HP) * 2;
        float tempPlus = (HP - refObj.GetComponent<PlayerScript>().HP) * 0.05f;

        barUpper.transform.localScale = new Vector3(tempX, barUpper.transform.localScale.y, barUpper.transform.localScale.z);
        barUpper.transform.position = new Vector3(barSpaceX + this.transform.position.x - tempXupper - tempPlus, barSpaceY + this.transform.position.y, 0.0f);

        // PlayerのHP(音符)を設置
        //for (int i = 0; i < refObj.GetComponent<PlayerScript>().HP; i++)
        //{
        //    if (cloneOnpu[i] == null)
        //    {
        //        GameObject Onpu = (GameObject)Resources.Load("Onpu");
        //        cloneOnpu[i] = Instantiate(Onpu, new Vector3(this.transform.position.x - CameraWidth + onpuSpaceX + (onpuToOnpuSpace * i), this.transform.position.y + this.GetComponent<Camera>().orthographicSize - onpuSpaceY, 0.0f), Quaternion.identity);
        //    }

        //    cloneOnpu[i].transform.position = new Vector3(this.transform.position.x - CameraWidth + onpuSpaceX + (onpuToOnpuSpace * i), this.transform.position.y + this.GetComponent<Camera>().orthographicSize - onpuSpaceY, 0.0f);
        //}

        //for (int i = refObj.GetComponent<PlayerScript>().HP; i < ONPU_MAX; i++)
        //{
        //    if (cloneOnpu[i])
        //    {
        //        Destroy(cloneOnpu[i]);
        //    }
        //}
    }
}
