using UnityEngine;

namespace CodeBase.Data.Configurations
{
    [CreateAssetMenu(fileName = "LevelConfiguration", menuName = "Configurations/LevelConfiguration")]
    public class LevelConfiguration : ScriptableObject
    {
        public string levelID;
    }
}