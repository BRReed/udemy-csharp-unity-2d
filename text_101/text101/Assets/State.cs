using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    // TextArea makes the story text box in unity inspector the size of the 
    // given dimensions. In this case 10 x 14
    [TextArea(10,14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    public State[] GetNextStates()
    {
        return nextStates;
    }

    public string GetStateStory()
    {
        return storyText;
    }
}
