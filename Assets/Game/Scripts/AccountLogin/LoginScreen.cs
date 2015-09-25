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
	private string loginURL = "http://piidz.x10host.com/UnityTestLogin/LoginAccountT.php";

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
			if(createAccountReturn == "Success")
			{
				Debug.LogError ("SUCCESS! Account created.");
			}
		}
	}

	private IEnumerator LogIn()
	{
		Debug.Log ("Attempting to Login");
		WWWForm form = new WWWForm ();
		form.AddField ("user", userInput.text);
		form.AddField ("password", passwordInput.text);

		WWW loginAccountWWW = new WWW (loginURL, form);

		yield return loginAccountWWW;

		if(loginAccountWWW.error != null)
		{
			Debug.LogError ("Cannot log in.");
		}

		else
		{
			string loginReturn = loginAccountWWW.text;

			string[] logTextSplit = loginReturn.Split(':');

			if(logTextSplit[0] == userInput.text)
			{
				if(logTextSplit[1] == "Success")
				{
					Debug.LogError("Log in successful.");
				}
			}

			else
			{
				Debug.LogError("User or password does not exist.");
			}
		}

	}
}
