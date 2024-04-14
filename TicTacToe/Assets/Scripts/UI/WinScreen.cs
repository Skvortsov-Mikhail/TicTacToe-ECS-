using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TicTacToe
{
    public class WinScreen : Screen
    {
        public Text Text;

        public void SetWinner(SignType winnerType) 
        {
            switch (winnerType)
            {
                case SignType.Cross:
                    Text.text = "Победа крестиков";
                    break;
                case SignType.Ring:
                    Text.text = "Победа ноликов";
                    break;
            }
        }
    }
}