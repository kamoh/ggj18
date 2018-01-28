using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
     
public class Reset : MonoBehaviour {
     

    public void RestartGame() 
    	{
			Debug.Log ("reset clicked");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
             // loads current scene
        }
     
    }