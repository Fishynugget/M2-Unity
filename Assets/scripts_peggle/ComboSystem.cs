using UnityEngine;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

public class ComboSystem : MonoBehaviour
{
    private List<string> bumperTags = new List<string>();

    private int scoreMultiplier = 1;
    
    public static event Action<int, int> OnScoreChange;

    private void Start()
    {
        BumperHit.onBumperHit += CheckForCombo;
    }
    private void OnDisable()
    {
        BumperHit.onBumperHit -= CheckForCombo;
    }
    private void CheckForCombo(Transform transform, int bumperValue) 
    {
       
        bumperTags.Add(transform.gameObject.tag);
        if (bumperTags.Count > 1) {

            if (bumperTags[bumperTags.Count - 2] == bumperTags[bumperTags.Count - 1])
            {

                scoreMultiplier++;
            }
            else
            {
                scoreMultiplier = 1;
                bumperTags.Clear();
            }
        }
        ScoreManager.Instance.AddScore(bumperValue * scoreMultiplier);
        
        OnScoreChange?.Invoke(ScoreManager.Instance.score, scoreMultiplier);
    }
}