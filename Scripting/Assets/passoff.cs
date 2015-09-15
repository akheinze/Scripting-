using UnityEngine;
using System.Collections;

public class passoff : MonoBehaviour
{   
	int myInt = 21;
	
	
	void Start ()
	{
		myInt = SubtractByThree(myInt);
		Debug.Log (myInt);
	}
	
	
	int SubtractByThree (int number)
	{
		int ret;
		ret = number - 3;
		return ret;
	}
}