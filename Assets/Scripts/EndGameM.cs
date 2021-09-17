using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameM : MonoBehaviour
{
    public static EndGameM Instance;
    // Start is called before the first frame update
    public void FinishGame()
    {
        Time.timeScale=0;
    }

    
}
