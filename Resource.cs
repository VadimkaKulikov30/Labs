
namespace Lab_1
{
    class Resource
    {
        private Process activeProcess;
        public Process ActiveProcess {
            get
            {
                return activeProcess;
            } 
            set 
            { 
                activeProcess = value;
                
            } 
        }

        public void WorkingCycle()
        {
            if (!IsFree())
            {
                activeProcess.IncreaseWorkTime();
            }
        }

        public bool IsFree()
        {
            return activeProcess == null;
        }

        public void Clear()
        {
            activeProcess = null;
        }
     
    }
}