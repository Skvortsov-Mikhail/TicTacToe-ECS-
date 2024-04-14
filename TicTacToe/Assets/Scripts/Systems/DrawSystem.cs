using Leopotam.Ecs;

namespace TicTacToe
{
    public class DrawSystem : IEcsRunSystem
    {
        private EcsFilter<Cell>.Exclude<Taken, Winner> _freeCells;
        private EcsFilter<Winner> _winner;
        private SceneData _sceneData = null;

        public void Run()
        {
            if(_freeCells.IsEmpty() && _winner.IsEmpty())
            {
                _sceneData.UI.LoseScreen.Show(true);
            }
        }
    }
}