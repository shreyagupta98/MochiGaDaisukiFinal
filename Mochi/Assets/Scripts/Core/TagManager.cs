using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagManager : MonoBehaviour 
{
	public static void Inject(ref string s)
	{
		if (!s.Contains("["))
			return;

		//prof kuma tag name
		s = s.Replace("[mainCharName]", "Kuma");

		//self character tag name
		s = s.Replace("[myCharName]", "Ushi");

		//arcade tag name
		s = s.Replace("[arcadeName]", "Arcade");

		//game tag name
		s = s.Replace("[gameName]", "Mochi Ga Daisuki");
    }

	public static string[] SplitByTags(string targetText)
	{
		return targetText.Split(new char[2]{'<','>'});
	}
}
