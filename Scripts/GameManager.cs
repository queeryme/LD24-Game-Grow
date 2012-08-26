using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GUISkin theGUI;

    private playerHealth pHealth;
    private playerEnergy pEnergy;

    private void Awake()
    {
        pHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<playerHealth>();
        pEnergy = GameObject.FindGameObjectWithTag("Player").GetComponent<playerEnergy>();
    }

    private void OnGUI()
    {
        GUI.skin = theGUI;
        GUI.Label(new Rect(10, 10, 70, 20), "Health");
        GUI.Label(new Rect(80, 10, 70, 20), pHealth.health.ToString());

        GUI.Label(new Rect(10, 30, 70, 20), "Energy");
        GUI.Label(new Rect(80, 30, 70, 20), pEnergy.energy.ToString());

        GUI.Label(new Rect(10, 50, 70, 20), "Speed");
        GUI.Label(new Rect(80, 50, 70, 20), TadPoleMovementController.speed.ToString());

        GUI.Label(new Rect(10, 70, 70, 20), "Grow Points");
        //GUI.Label(new Rect(80, 70, 70, 20), );

        //GUI.Label(new Rect(10, 100, 70, 40), "Timer");
    }

    //public void WrapToScreen()
    //{
    //    if (gameObject.transform.position.z > Top.transform.position.z)
    //        transform.position = new Vector3(transform.position.x, transform.position.y, Bot.transform.position.z + 5.0f);
    //    else if (gameObject.transform.position.z < Bot.transform.position.z)
    //        transform.position = new Vector3(transform.position.x, transform.position.y, Top.transform.position.z - 5.0f);
    //    else if (gameObject.transform.position.x < Left.transform.position.x)
    //        transform.position = new Vector3(Right.transform.position.x - 5.0f, transform.position.y, transform.position.z);
    //    else if (gameObject.transform.position.x > Right.transform.position.x)
    //        transform.position = new Vector3(Left.transform.position.x + 5.0f, transform.position.y, transform.position.z);
    //}
}
