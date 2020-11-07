namespace TicTacToe.Models
{
    public class Player
    {
        public Player(string name = "Anonymous", bool isHisMove = false)
        {
            IsHisMove = isHisMove;
            Name = name;
        }
        public string Name { get; set; }
        public char Icon { get; set; }

        public bool IsHisMove { get; set; }
    }
}
