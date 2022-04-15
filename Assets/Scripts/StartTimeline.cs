using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityStandardAssets.Characters.ThirdPerson;

public class StartTimeline : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject player;

    bool playScene = false;
    

    // Start is called before the first frame update
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && player.gameObject.GetComponent<PlayerCheck>().cutscene)
        {
            player.gameObject.GetComponent<ThirdPersonUserControl>().enabled = false;

            player.transform.localPosition = Vector3.zero;
            player.transform.localRotation = Quaternion.Euler(0, 90, 0);
            timeline.Play();
            playScene = true;
        }

        if (timeline.state != PlayState.Playing && playScene)
        {
            playScene = false;
            player.gameObject.GetComponent<ThirdPersonUserControl>().enabled = true;
        }
       
    }

}
