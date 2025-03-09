using UnityEngine;
using UnityEngine.SceneManagement;
public class GameReset : MonoBehaviour
{
        public void Reload()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    
}
