using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linker : MonoBehaviour
{
   public void OpenGame(Object button)
    {
        SceneManagment.Instance.OpenGame(button.name);
    }
}
