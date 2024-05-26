using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
   public void menu()
   {
    SceneManager.LoadScene("menu");
   }
   public void SampleScene()
   {
    SceneManager.LoadScene("SampleScene");
   }
}
