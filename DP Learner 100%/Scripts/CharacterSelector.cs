using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject james;
	public GameObject kate;
	public GameObject louise;

	public int characterSelected;

	void Start()
	{

		james.SetActive(true);
		kate.SetActive(false);
		louise.SetActive(false);

		characterSelected = 1;
	}

	public void loadjames()
	{

		james.SetActive(true);
		kate.SetActive(false);
		louise.SetActive(false);

		characterSelected = 1;
	}

	public void load458()
	{

		james.SetActive(false);
		kate.SetActive(true);
		louise.SetActive(false);

		characterSelected = 2;
	}

	public void loadlouise()
	{

		james.SetActive(false);
		kate.SetActive(false);
		louise.SetActive(true);

		characterSelected = 3;
	}

}
