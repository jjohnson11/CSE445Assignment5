using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void login_Click(object sender, EventArgs e)
    {
        /*Once they try to login, this is where you will call your DLL file to read the XML list of usernames and passwords. You will pass in the login information and it will return a User object.  The User object
          needs to return Username, Password, and whether they are an Administrator or not.
        */

        /*Then just add the username, password, and administrator value to to the Session variables.  At the top of each page I'll 
        just check to make sure that there is data in these two fields. If not, then we know they never logged in and we won't let them see the protected pages.*/
        //Session["username"] = userObject.username; //String
        //Session["password"] = userObject.password; //String
        //Session["admin"] = userObject.admin; //Boolean
    }
}