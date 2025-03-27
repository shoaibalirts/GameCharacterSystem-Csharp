namespace GameCharacterSystem
{
    public class Taxi
    {
        private string taxiTag;

        public Taxi(string tag) => taxiTag = tag;

        public override string ToString() => $"Taxi: {taxiTag}";
    }
}