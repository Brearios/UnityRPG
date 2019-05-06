using UnityEngine;

public class Portal : Collidable
{
    /*
     * Enter the differents scene names in the
     * sceneNames array, directly in the inspector
     * The portal will then choose one randomly and transfer
     * you in that scene.
     * 
     * Only enter one name if you need to be guaranted to go somewhere specific
     */

    public string[] sceneNames;

    // Override
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            // Teleport the player
            GameManager.instance.SaveState();
            string sceneName = sceneNames[Random.Range(0, sceneNames.Length)];
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}