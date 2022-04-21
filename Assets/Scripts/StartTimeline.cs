using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityStandardAssets.Characters.ThirdPerson;

public class StartTimeline : MonoBehaviour
{
    [SerializeField] private PlayerCheck PlayerCheck;
    [SerializeField] private PlayableDirector timeline;
    [SerializeField] private GameObject player;
    [SerializeField] private ThirdPersonUserControl UserControl;

    private bool playScene;
    private bool Cut;

    private void Start()
    {
        timeline = GetComponent<PlayableDirector>();
        UserControl = player.gameObject.GetComponent<ThirdPersonUserControl>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Cut)
        {
            UserControl.enabled = false;
            player.transform.localPosition = Vector3.zero;
            player.transform.localRotation = Quaternion.Euler(0, 90, 0);
            timeline.Play();
            playScene = true;
        }

        if (timeline.state != PlayState.Playing && playScene)
        {
            playScene = false;
            UserControl.enabled = true;
        }
    }

    public void GetBoolCheck(bool cutscene)
    {
        Cut = cutscene;
    }
}
