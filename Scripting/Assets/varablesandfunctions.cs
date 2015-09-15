using UnityEngine;
using System.Collections;

public class pasoff : MonoBehaviour
{   

	int myInt = 21;
	
	
	void Start ()
	{
		myInt = DivideByThree(myInt);
		Debug.Log (myInt);
	}


	
	int DivideByThree (int number)
	{
		int ret;
		ret = number / 3;
		return ret;
	}
}