
namespace Prb.Structs.Wpf
{
    struct Coordinate
    {
        public readonly int x;
        public readonly int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Coordinate MoveUp()
        {
            return new Coordinate(x, y + 1);
        }

        public Coordinate MoveDown()
        {
            return new Coordinate(x, y - 1);
        }

        public Coordinate MoveLeft()
        {
            return new Coordinate(x - 1, y);
        }

        public Coordinate MoveRight()
        {
            return new Coordinate(x + 1, y);
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}