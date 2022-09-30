using System;
namespace Lab_1
{
    public class IdGenerator
    {
        private long id;
        public long Id
        {
            get { return id == long.MaxValue ? 0 : id++; }
        }

        public IdGenerator Clear()
        {
            if (this != null)
            {
                id = 0;
            }
            return this;
        }
    }
}
