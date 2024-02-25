namespace Dictionary.Enemies
{
    internal abstract class Enemy
    {
        private int _hp;
        public int HP
        {
            get
            {  
                return _hp;
            }
            set
            {
                if (value < 0)
                    value = 0;
                _hp = value;
            }
        }
        public abstract override string ToString();
    }
}
