using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class ObjectDisposalPattern : IDisposable
    {
        static bool doneObjectDisposal = false;
        public void Dispose()
        {
            //object user calls the disposal logic
            DisposalLogicHelper(true);
            GC.SuppressFinalize(this); 
        }

        void DisposalLogicHelper(bool consumer)
        {
            //if object is not yet disposed
            if(!doneObjectDisposal)
            {
                if(consumer)
                {
                    //dispose managed resources
                }
                //dispose unmanaged resources
                doneObjectDisposal = true;
            }            
        }

        ~ObjectDisposalPattern()
        {
            //GC calls the disposal logic
            DisposalLogicHelper(false);
        }
    }
}
