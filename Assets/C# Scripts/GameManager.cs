using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    public bool gameend;
    public Transform player;
    public void Endgame(){
        
        if(gameend == false && player.transform.position.y < 10){
            Debug.Log("GameOver\n");
            gameend=true;
        }

    }
    void Update(){
        if(gameend == true){
            if(Input.GetKey(KeyCode.Space)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
