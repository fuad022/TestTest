namespace test
{
    public class Bmw : ICar
    {
        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}