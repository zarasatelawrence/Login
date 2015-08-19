using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LoginScreen : MonoBehaviour {
	public static string EMAIL_STRING = "";
	public static string PASSWORD_STRING = "";

	[SerializeField] private InputField userInput;
	[SerializeField] private InputField passwordInput;

	private string createAccountURL = "http://piidz.x10host.com/UnityTestLogin/CreateAccountT.php";
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
		Debug.Log ("SIGN UP BUTTON CLICKED");

//		if (userInput.text == "" || passwordInput.text == "")
//		{
//			Debug.LogError ("NO EMAIL OR PASSWORD INPUT");
//			yield return new WaitForSeconds(0f);
//		}

		WWWForm form = new WWWForm ();
		form.AddField ("user", userInput.text);
		form.AddField ("password", passwordInput.text);
		
		WWW createAccountWWW = new WWW (createAccountURL, form);

		yield return createAccountWWW;

		if (createAccountWWW.error != null)
		{
			Debug.LogError("Cannot connect to Account Creation");
		}

		else
		{
			string createAccountReturn = createAccountWWW.text;
			Debug.LogError (createAccountReturn);
			if(createAccountReturn == "Success")
			{
				Debug.Log ("SUCCESS! Account created.");
			}
		}
	}

	private IEnumerator LogIn()
	{
		if (userInput.text == "" || passwordInput.text == "")
		{
			Debug.LogError ("NO EMAIL OR PASSWORD INPUT");
		}

		// yield return new should wait for a return from your database
		// use that variable instead of waitforseconds
		yield return new WaitForSeconds (0.5f);

		Debug.Log ("SIGN IN BUTTON CLICKED");
	}
}
