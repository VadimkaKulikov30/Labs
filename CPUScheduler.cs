using Queues;
using System;

namespace Lab_1
{
    class CPUScheduler
    {
        private Resource resource;
        private IQueueable<Process> queue;

        public CPUScheduler(Resource resource, IQueueable<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }

        public IQueueable<Process> Session()
        {
            Process tmpProc = queue.Item();
            tmpProc.Status = ProcessStatus.running;
            queue.Remove();
            resource.ActiveProcess = tmpProc;
            return queue;
        }
    }
}