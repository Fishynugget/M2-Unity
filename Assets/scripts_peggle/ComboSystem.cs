using UnityEngine;
using System.Collections.Generic;

public class ComboSystem : MonoBehaviour
{
    private List<string> bumperTags = new List<string>();

    private int scoreMultiplier = 1;

    private void Start()
    {
        BumperHit.onBumperHit += CheckForCombo;
    }
    private void OnDisable()
    {
        BumperHit.onBumperHit -= CheckForCombo;
    }
    private void CheckForCombo(string tag, int bumperValue) {
       
        bumperTags.Add(tag);
        if (bumperTags.Count > 1) {

            if (bumperTags[bumperTags.Count - 2] == bumperTags[bumperTags.Count - 1])
            {

                Debug.Log("Combo detected with tag: " + tag);
                scoreMultiplier++;
            }
            else
            {
                scoreMultiplier = 1;
                bumperTags.Clear();
            }
        }

        Debug.Log("Score multiplier: " + scoreMultiplier);
    }
}