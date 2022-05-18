using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar_animeController8 : MonoBehaviour
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

        if(barNum == 8)
		{
            anim.SetBool("Big", true);
		}
        else if (barNum == 7 || barNum == 9)
        {
            anim.SetBool("Big", false);
		}
    }
}
