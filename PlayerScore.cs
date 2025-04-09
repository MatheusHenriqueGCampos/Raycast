using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public static int currentScore = 0;
    private void OnGUI()
    {
        GUILayout.Label($"<size=100><color='black'>{currentScore}</size></color>");
    }
}
