using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
  public void PlayGame()
    {
        int SelectedCharacter = 
            int .Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name );
        


        GameManager.Instance.charIndex = SelectedCharacter;
        //Debug.Log("index colon "+ clickedObj);
        SceneManager.LoadScene("Game Play");


    }

    
}
