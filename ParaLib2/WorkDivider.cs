using System;

namespace ParaLib2
{
    public class WorkDivider
    {
        private int listSize;
        private Map map;
        private Worker[] worker;

        public WorkDivider(int listSize, int threadCount)
        {
            this.listSize = listSize;
        }

        public void ExecuteThreadWork(Object worker)
        {
           Worker work = (Worker)worker;
        }

        private void InlizielizeWorkers(int threadCount)
        {
            worker = new Worker[listSize];

            for (int i = 0; i < threadCount; i++)
            {
                worker[i] = new Worker();
            }
        }
    }
}
