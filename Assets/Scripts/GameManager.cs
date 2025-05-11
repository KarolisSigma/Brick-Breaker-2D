using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int bricksLeft;
    public string nextLevel;

    void Awake()
    {
        if(instance==null) instance=this;
    }

    public void UpdateBricks(int amount){
        bricksLeft+=amount;
        if(bricksLeft==0) SceneManager.LoadScene(nextLevel);
    }

    public void Lost(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
