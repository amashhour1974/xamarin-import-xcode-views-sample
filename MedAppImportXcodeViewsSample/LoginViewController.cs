using Foundation;
using System;
using UIKit;
using System.Threading;

namespace MedAppImportXcodeViewsSample
{
    public partial class LoginViewController : UIViewController
    {
		
        public LoginViewController (IntPtr handle) : base (handle)
        {
        }

		partial void emergencyLoginTapped(UIButton sender)
		{

		}

	    partial void  loginButtonTapped(UIButton sender)
		{
			string username = loginTextField.Text;
			string password = passwordTextField.Text;
			int loggedIn = 0;
			string msg = "";

			//TODO Add login with a web service 
			//and change "loggedIn" value accordingly
			//0 - not logged in
			//other number represents logged in user ID

			//CancellationTokenSource cts = new CancellationTokenSource();

			//LoginApiService loginApiService = new LoginApiService(new ApiClient());
			//loggedIn = await loginApiService.LogInPatientAsync(username, password, cts.Token);

			if (loggedIn == 0)
			{
				msg = "Not logged in. Try with different username and password";
			}
			else
			{
				msg = "Logged in successfully as UserID:" + loggedIn;
			}
			UIAlertController alertView = UIAlertController.Create("Sign in", msg,UIAlertControllerStyle.Alert);
			alertView.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, null));
			PresentViewController(alertView, true, null);



		}

		partial void privacyPolicyButtonTapped(UIButton sender)
		{

		}
    }
}