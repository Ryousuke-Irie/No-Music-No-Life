using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar_animeController17 : MonoBehaviour
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

        if(barNum == 17)
		{
            anim.SetBool("Big", true);
		}
        else if (barNum == 16 || barNum == 18)
        {
            anim.SetBool("Big", false);
		}
    }
}
