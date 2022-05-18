using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar_animeController6 : MonoBehaviour
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

        if(barNum == 6)
		{
            anim.SetBool("Big", true);
		}
        else if (barNum == 5 || barNum == 7)
        {
            anim.SetBool("Big", false);
		}
    }
}
