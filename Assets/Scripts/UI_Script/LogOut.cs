using UnityEngine;
using UnityEngine.SceneManagement;


public class LogOut : MonoBehaviour
{
    public void OnClickLogOut()
    {
        AuthManager.firebaseAuth.SignOut();
        AuthManager.User = null;
        SceneManager.LoadScene("SignIn");
        Debug.Log("Log-out");
    }
}
