using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar_animeController2 : MonoBehaviour
{
    private int barNum;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        barNum = StageSelectController.getBarNum();

        if(barNum == 2)
		{
            anim.SetBool("Big", true);
		}
        else if (barNum == 1 || barNum == 3)
        {
            anim.SetBool("Big", false);
		}
    }
}
