using UnityEngine;

namespace CodeBase.InGame.Configurations
{
    [CreateAssetMenu(fileName = "LevelConfiguration", menuName = "Configurations/LevelConfiguration")]
    public class LevelConfiguration : ScriptableObject
    {
        public string levelID;
    }
}