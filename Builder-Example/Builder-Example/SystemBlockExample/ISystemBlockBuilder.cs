using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Example.SystemBlockExample
{
    public interface ISystemBlockBuilder
    {
        void setBody();
        void setMotherBoard();
        void setPSU();
        void setCPU();
        void setRAM();
        void setVideoAdapter();
        void setNetworkAdapter();
        void setSoundAdapter();
        void setHardDrive();
        void setSSD();
    }
}
