using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionCheck : MonoBehaviour
{
    /// <summary>
    /// îªíËì‡Ç…ìGÇ©ï«Ç™Ç†ÇÈ
    /// </summary>
    [HideInInspector] public bool isOn = false;

    private string groundTag = "Wall";
    private string enemyTag = "Enemy";

	#region // ê⁄êGîªíË
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == groundTag || collision.tag == enemyTag)
		{
            isOn = true;
			this.transform.position += new Vector3(0.0f, 0.2f, 0.0f);
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == groundTag || collision.tag == enemyTag)
		{
			isOn = false;
			this.transform.position += new Vector3(0.0f, 0.2f, 0.0f);
		}
	}
	#endregion
}
