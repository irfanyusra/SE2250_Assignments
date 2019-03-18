using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareScript : MonoBehaviour
{
    

	public void shareWithTwitter()
	{

		string text = "MY%20SCORE%20IS:%20" + ScoreManager.SCORE + "!!!!";
		Application.OpenURL("https://twitter.com/intent/tweet?text=" + text);

	}
}

