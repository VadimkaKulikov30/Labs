﻿using System;
namespace Lab_1
{
    public class Settings
    {
        private double intensity;
        private int minValueOfBurstTime;
        private int maxValueOfBurstTime;
        private int minValueOfAddrSpace;
        private int maxValueOfAddrSpace;
        private int valueOfRAMSize;
        private int maxQuantum;
        public double Intensity
        {
            get
            {
                return intensity;
            }
            set
            {
                intensity = value;
            }
        }
        public int MinValueOfBurstTime
        {
            get
            {
                return minValueOfBurstTime;
            }
            set
            {
                minValueOfBurstTime = value;
            }
        }
        public int MaxValueOfBurstTime
        {
            get
            {
                return maxValueOfBurstTime;
            }
            set
            {
                maxValueOfBurstTime = value;
            }

        }
        public int MinValueOfAddrSpace
        {
            get
            {
                return minValueOfAddrSpace;
            }
            set
            {
                minValueOfAddrSpace = value;
            }

        }
        public int MaxValueOfAddrSpace
        {
            get
            {
                return maxValueOfAddrSpace;
            }
            set
            {
                maxValueOfAddrSpace = value;
            }

        }
        public int ValueOfRAMSize
        {
            get
            {
                return valueOfRAMSize;
            }
            set
            {
                valueOfRAMSize = value;
            }
        }
        public int MaxQuantum
        {
            get
            {
                return maxQuantum;
            }
            set
            {
                maxQuantum = value;
            }
        }
    }
}