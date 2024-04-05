using UnityEngine;

namespace TicTacToe
{
    [CreateAssetMenu]
    public class Configuration : ScriptableObject
    {
        public int FieldWidth = 3;
        public int FieldHeight = 3;
        public int ChainLength = 3;
        public CellView CellView;
        public Vector2 Offset;
    }
}