﻿using System;

namespace Lab_1
{
    public class MemoryManager
    {
        public void Save(Memory memory)
        {
            this.memory = memory;
        }

        public Memory Allocate(long size)
        {
            if (size <= memory.FreeSize)
            {
                memory.OccupiedSize += size;
                return memory;
            }
            return null;
        }

        public Memory Free(long size)
        {
            memory.OccupiedSize -= size;
            return memory;
        }
        private Memory memory;
    }
}