using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    public Animator animator;



    void Start()
    {
        
    }

    public void PlayerDamaged()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
