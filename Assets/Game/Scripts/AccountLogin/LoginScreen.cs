using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LoginScreen : MonoBehaviour {
	public static string EMAIL_STRING = "";
	public static string PASSWORD_STRING = "";

	[SerializeField] private InputField emailInput;
	[SerializeField] private InputField passwordInput;

	private string createAccountURL = "";
	private string loginURL = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnSignUpButtonClick()
	{
		StartCoroutine (SignUp());
	}

	public void OnLogInButtonClick()
	{
		StartCoroutine (LogIn());
	}

	private IEnumerator SignUp()
	{
		if (emailInput.text == "" || passwordInput.text == "")
		{
			Debug.LogError ("NO EMAIL OR PASSWORD INPUT");
		}

		// yield return new should wait for a return from your database
		// use that variable instead of waitforseconds
		yield return new WaitForSeconds (0.5f);

		Debug.Log ("SIGN UP BUTTON CLICKED");
	}

	private IEnumerator LogIn()
	{
		if (emailInput.text == "" || passwordInput.text == "")
		{
			Debug.LogError ("NO EMAIL OR PASSWORD INPUT");
		}

		// yield return new should wait for a return from your database
		// use that variable instead of waitforseconds
		yield return new WaitForSeconds (0.5f);

		Debug.Log ("SIGN IN BUTTON CLICKED");
	}
}
