using System;

namespace Lab_1
{
    public class Memory
    {
        public long Size
        {
            get;
            private set;
        }
        public long FreeSize { 
            get
            {
                return Size - occupiedSize;
            }
            private set
            {
                
            }
        }
        
        private long occupiedSize;
        public long OccupiedSize { 
            get 
            {
                return occupiedSize;
            } 
            set {
                occupiedSize = value;
                FreeSize = Size - occupiedSize;
            } 
        }     
        public void Save(long size)
        {
            Size = size;
            OccupiedSize = 0;
        }

        public void Clear()
        {
            FreeSize = 0;
            OccupiedSize = 0;
        }
    }
}