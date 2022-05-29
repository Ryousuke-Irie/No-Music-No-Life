using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataDeleteScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        // PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("StageRank00", 0);
        PlayerPrefs.SetInt("StageRank01", 0);
        PlayerPrefs.SetInt("StageRank02", 0);
        PlayerPrefs.SetInt("StageRank03", 0);
        PlayerPrefs.SetInt("StageRank04", 0);
        PlayerPrefs.SetInt("StageRank05", 0);
        PlayerPrefs.SetInt("StageRank06", 0);
        PlayerPrefs.SetInt("StageRank07", 0);
        PlayerPrefs.SetInt("StageRank08", 0);
        PlayerPrefs.SetInt("StageRank09", 0);
        PlayerPrefs.SetInt("StageRank10", 0);
        PlayerPrefs.SetInt("StageRank11", 0);
        PlayerPrefs.SetInt("StageRank12", 0);
        PlayerPrefs.SetInt("StageRank13", 0);
        PlayerPrefs.SetInt("StageRank14", 0);
        PlayerPrefs.SetInt("StageRank15", 0);
        PlayerPrefs.SetInt("StageRank16", 0);
        PlayerPrefs.SetInt("StageRank17", 0);
        PlayerPrefs.SetInt("StageRank18", 0);
        PlayerPrefs.SetInt("StageRank19", 0);

        PlayerPrefs.SetInt("StageScore00", 0);
        PlayerPrefs.SetInt("StageScore01", 0);
        PlayerPrefs.SetInt("StageScore02", 0);
        PlayerPrefs.SetInt("StageScore03", 0);
        PlayerPrefs.SetInt("StageScore04", 0);
        PlayerPrefs.SetInt("StageScore05", 0);
        PlayerPrefs.SetInt("StageScore06", 0);
        PlayerPrefs.SetInt("StageScore07", 0);
        PlayerPrefs.SetInt("StageScore08", 0);
        PlayerPrefs.SetInt("StageScore09", 0);
        PlayerPrefs.SetInt("StageScore10", 0);
        PlayerPrefs.SetInt("StageScore11", 0);
        PlayerPrefs.SetInt("StageScore12", 0);
        PlayerPrefs.SetInt("StageScore13", 0);
        PlayerPrefs.SetInt("StageScore14", 0);
        PlayerPrefs.SetInt("StageScore15", 0);
        PlayerPrefs.SetInt("StageScore16", 0);
        PlayerPrefs.SetInt("StageScore17", 0);
        PlayerPrefs.SetInt("StageScore18", 0);
        PlayerPrefs.SetInt("StageScore19", 0);

        PlayerPrefs.SetInt("tutorial", 0);
    }
}
