using System;

namespace Lab_1
{
    public enum ProcessStatus
    {
        ready,
        running,
        waiting,
        terminated
    }

    public class Process: IComparable<Process>
    {
        public Process(long pid, long addrSpace)
        {
            //ArrivalTime = startTime;
            id = pid;
            AddrSpace = addrSpace;           
            name = "P" + pid.ToString();

            Status = ProcessStatus.ready;
        }

        public void IncreaseWorkTime()
        {
            if (workTime < BurstTime)
            {
                workTime++;
                return;
            }
            if (this.Status == ProcessStatus.running)
            {
                this.Status = random.Next(0, 2) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
            }
            else
            { 
                Status = ProcessStatus.ready;
            }
        }
        
        public void ResetWorkTime()
        {
            workTime = 0;
        }

        public override string ToString()
        {
            string result = "Id: " + id.ToString() + " Name: " + name + " Status: " + Status + " BurstTime: " + BurstTime + " AddrSpace: " + AddrSpace;
            return result;
        }

        public int CompareTo(Process other)
        {
            if (other == null)
            {
                return 1;
            }
            return other.BurstTime.CompareTo(BurstTime);
        }
        
        //индификатор процесса
        private long id;
        // имя
        private string name;
        // общее время работы на цп
        private long workTime;

        //private long commonWorkTime;
        //интервал обслудивания на цп
        public long BurstTime { get; set; }
        // состояние процесса
        public ProcessStatus Status { get; set; }    
        //время постановки в очередь готовых процессов 
        public long ReadyQueueArrivalTime { get; set; }
        // адрессное пространство процесса 
        public long AddrSpace { get; private set; }
        // время поступления процесса в систему 

        private Random random = new Random();
        //ResourceEventArgs device = new ResourceEventArgs();
    }

    public class HelloWorld
    {
        static void Main()
        {
            Process proc;
            proc = new Process(156, 1000);
            proc.BurstTime = 128;
            Console.WriteLine(proc.ToString());
        }
    }
}